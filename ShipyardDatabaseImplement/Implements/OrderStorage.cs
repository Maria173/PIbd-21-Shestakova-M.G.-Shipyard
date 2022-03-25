using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShipyardContracts.BindingModels;
using ShipyardContracts.StoragesContracts;
using ShipyardContracts.ViewModels;
using ShipyardDatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;

namespace ShipyardDatabaseImplement.Implements
{
    public class OrderStorage : IOrderStorage
    {
        public List<OrderViewModel> GetFullList()
        {
            using var context = new ShipyardDatabase();
            return context.Orders.Include(rec => rec.Ship).ToList().Select(rec => new OrderViewModel
            {
                Id = rec.Id,
                ShipId = rec.ShipId,
                ShipName = rec.Ship.ShipName,
                Count = rec.Count,
                Sum = rec.Sum,
                Status = rec.Status,
                DateCreate = rec.DateCreate,
                DateImplement = rec.DateImplement
            }).ToList();
        }
        public List<OrderViewModel> GetFilteredList(OrderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new ShipyardDatabase();
            return context.Orders.Include(rec => rec.Ship)
                    .Where(rec => rec.ShipId == model.ShipId || rec.DateCreate >= model.DateFrom && rec.DateCreate <= model.DateTo)
                    .ToList().Select(rec => new OrderViewModel
                    {
                Id = rec.Id,
                ShipId = rec.ShipId,
                ShipName = rec.Ship.ShipName,
                Count = rec.Count,
                Sum = rec.Sum,
                Status = rec.Status,
                DateCreate = rec.DateCreate,
                DateImplement = rec.DateImplement
            }).ToList();
        }
        public OrderViewModel GetElement(OrderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new ShipyardDatabase())
            {
                var order = context.Orders.Include(rec => rec.Ship).FirstOrDefault(rec => rec.Id == model.Id);
                return order != null ? CreateModel(order, context) : null;
            }
        }
        public void Insert(OrderBindingModel model)
        {
            using (var context = new ShipyardDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.Orders.Add(CreateModel(model, new Order()));
                        context.SaveChanges();
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
        public void Update(OrderBindingModel model)
        {
            using (var context = new ShipyardDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var element = context.Orders.FirstOrDefault(rec => rec.Id == model.Id);
                        if (element == null)
                        {
                            throw new Exception("Элемент не найден");
                        }
                        CreateModel(model, element);
                        context.SaveChanges();
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
        public void Delete(OrderBindingModel model)
        {
            using (var context = new ShipyardDatabase())
            {
                Order element = context.Orders.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Orders.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }
        public static Order CreateModel(OrderBindingModel model,
            Order order)
        {
            order.ShipId = model.ShipId;
            order.Count = model.Count;
            order.Sum = model.Sum;
            order.Status = model.Status;
            order.DateCreate = model.DateCreate;
            order.DateImplement = model.DateImplement;
            return order;
        }
        public OrderViewModel CreateModel(Order order, ShipyardDatabase context)
        {
            return new OrderViewModel
            {
                Id = order.Id,
                ShipId = order.ShipId,
                ShipName = order.Ship.ShipName,
                Count = order.Count,
                Sum = order.Sum,
                Status = order.Status,
                DateCreate = order.DateCreate,
                DateImplement = order.DateImplement
            };
        }
    }
}