using ShipyardContracts.BindingModels;
using ShipyardContracts.StoragesContracts;
using ShipyardContracts.ViewModels;
using ShipyardFileImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
namespace ShipyardFileImplement.Implements
{
    public class ShipStorage : IShipStorage
    {
        private readonly FileDataListSingleton source;
        public ShipStorage()
        {
            source = FileDataListSingleton.GetInstance();
        }
        public List<ShipViewModel> GetFullList()
        {
            return source.Ships
            .Select(CreateModel)
            .ToList();
        }
        public List<ShipViewModel> GetFilteredList(ShipBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            return source.Ships
            .Where(rec => rec.ShipName.Contains(model.ShipName))
            .Select(CreateModel)
            .ToList();
        }
        public ShipViewModel GetElement(ShipBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            var ship = source.Ships
            .FirstOrDefault(rec => rec.ShipName == model.ShipName || rec.Id
           == model.Id);
            return ship != null ? CreateModel(ship) : null;
        }
        public void Insert(ShipBindingModel model)
        {
            int maxId = source.Ships.Count > 0 ? source.Components.Max(rec => rec.Id)
: 0;
            var element = new Ship
            {
                Id = maxId + 1,
                ShipComponents = new
           Dictionary<int, int>()
            };
            source.Ships.Add(CreateModel(model, element));
        }
        public void Update(ShipBindingModel model)
        {
            var element = source.Ships.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            CreateModel(model, element);
        }
        public void Delete(ShipBindingModel model)
        {
            Ship element = source.Ships.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                source.Ships.Remove(element);
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
        private static Ship CreateModel(ShipBindingModel model, Ship ship)
        {
            ship.ShipName = model.ShipName;
            ship.Price = model.Price;
            // удаляем убранные
            foreach (var key in ship.ShipComponents.Keys.ToList())
            {
                if (!model.ShipComponents.ContainsKey(key))
                {
                    ship.ShipComponents.Remove(key);
                }
            }
            // обновляем существуюущие и добавляем новые
            foreach (var component in model.ShipComponents)
            {
                if (ship.ShipComponents.ContainsKey(component.Key))
                {
                    ship.ShipComponents[component.Key] =
                   model.ShipComponents[component.Key].Item2;
                }
                else
                {
                    ship.ShipComponents.Add(component.Key,
                   model.ShipComponents[component.Key].Item2);
                }
            }
            return ship;
        }
        private ShipViewModel CreateModel(Ship product)
        {
            return new ShipViewModel
            {
                Id = product.Id,
                ShipName = product.ShipName,
                Price = product.Price,
                ShipComponents = product.ShipComponents
                .ToDictionary(recPC => recPC.Key, recPC =>
                (source.Components.FirstOrDefault(recC => recC.Id ==
                recPC.Key)?.ComponentName, recPC.Value))
            };
        }
    }
}
