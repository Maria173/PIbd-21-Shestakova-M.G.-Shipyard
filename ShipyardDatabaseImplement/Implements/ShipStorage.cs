using System;
using System.Collections.Generic;
using System.Linq;
using ShipyardDatabaseImplement.Models;
using ShipyardContracts.BindingModels;
using ShipyardContracts.StoragesContracts;
using ShipyardContracts.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace ShipyardDatabaseImplement.Implements
{
    public class ShipStorage : IShipStorage
    {
        public List<ShipViewModel> GetFullList()
        {
            using var context = new ShipyardDatabase();
            return context.Ships.Include(rec => rec.ShipComponents).ThenInclude(rec => rec.Component).ToList().Select(CreateModel).ToList();
        }
        public List<ShipViewModel> GetFilteredList(ShipBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new ShipyardDatabase();
            return context.Ships.Include(rec => rec.ShipComponents).ThenInclude(rec => rec.Component).Where(rec => rec.ShipName.Contains(model.ShipName)).ToList().Select(CreateModel).ToList();
        }
        public ShipViewModel GetElement(ShipBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new ShipyardDatabase();
            var ship = context.Ships.Include(rec => rec.ShipComponents).ThenInclude(rec => rec.Component).FirstOrDefault(rec => rec.ShipName == model.ShipName || rec.Id == model.Id);
            return ship != null ? CreateModel(ship) : null;
        }
        public void Insert(ShipBindingModel model)
        {
            using var context = new ShipyardDatabase();
            using var transaction = context.Database.BeginTransaction();
            try
            {
                Ship ship = new Ship()
                {
                    ShipName = model.ShipName,
                    Price = model.Price
                };
                context.Ships.Add(ship);
                context.SaveChanges();
                CreateModel(model, ship, context);
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }
        public void Update(ShipBindingModel model)
        {
            using var context = new ShipyardDatabase();
            using var transaction = context.Database.BeginTransaction();
            try
            {
                var element = context.Ships.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Элемент не найден");
                }
                CreateModel(model, element, context);
                context.SaveChanges();
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }
        public void Delete(ShipBindingModel model)
        {
            using var context = new ShipyardDatabase();
            Ship element = context.Ships.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.Ships.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
        private static Ship CreateModel(ShipBindingModel model, Ship ship, ShipyardDatabase context)
        {
            ship.ShipName = model.ShipName;
            ship.Price = model.Price;
            if (model.Id.HasValue)
            {
                var shipComponents = context.ShipComponents.Where(rec => rec.ShipId == model.Id.Value).ToList();
                context.ShipComponents.RemoveRange(shipComponents.Where(rec => !model.ShipComponents.ContainsKey(rec.ComponentId)).ToList());
                context.SaveChanges();
                foreach (var updateComponent in shipComponents)
                {
                    updateComponent.Count = model.ShipComponents[updateComponent.ComponentId].Item2;
                    model.ShipComponents.Remove(updateComponent.ComponentId);
                }
                context.SaveChanges();
            }
            foreach (var pc in model.ShipComponents)
            {
                context.ShipComponents.Add(new ShipComponent
                {
                    ShipId = ship.Id,
                    ComponentId = pc.Key,
                    Count = pc.Value.Item2
                });
                context.SaveChanges();
            }
            return ship;
        }
        private static ShipViewModel CreateModel(Ship ship)
        {
            return new ShipViewModel
            {
                Id = ship.Id,
                ShipName = ship.ShipName,
                Price = ship.Price,
                ShipComponents = ship.ShipComponents.ToDictionary(recPC => recPC.ComponentId, recPC => (recPC.Component?.ComponentName, recPC.Count))
            };
        }
    }
}