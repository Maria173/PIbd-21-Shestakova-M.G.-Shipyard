using ShipyardContracts.BindingModels;
using ShipyardContracts.StoragesContracts;
using ShipyardContracts.ViewModels;
using ShipyardListImplement.Models;
using System;
using System.Collections.Generic;

namespace ShipyardListImplement.Implements
{
    public class OrderStorage : IOrderStorage
    {
        private readonly DataListSingleton _source;

        public OrderStorage()
        {
            _source = DataListSingleton.GetInstance();
        }

        public List<OrderViewModel> GetFullList()
        {
            List<OrderViewModel> result = new List<OrderViewModel>();
            foreach (var component in _source.Orders)
            {
                result.Add(CreateModel(component));
            }
            return result;
        }

        public List<OrderViewModel> GetFilteredList(OrderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            List<OrderViewModel> result = new List<OrderViewModel>();
            foreach (var Order in _source.Orders)
            {
                if ((!model.DateFrom.HasValue && !model.DateTo.HasValue && Order.DateCreate == model.DateCreate) ||
            (model.DateFrom.HasValue && model.DateTo.HasValue && Order.DateCreate.Date >= model.DateFrom.Value.Date && Order.DateCreate.Date <= model.DateTo.Value.Date) ||
            (model.ClientId.HasValue && Order.ClientId == model.ClientId))
                {
                    result.Add(CreateModel(Order));
                }
            }
            return result;
        }

        public OrderViewModel GetElement(OrderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            foreach (var Order in _source.Orders)
            {
                if (Order.Id == model.Id)
                {
                    return CreateModel(Order);
                }
            }
            return null;
        }

        public void Insert(OrderBindingModel model)
        {
            Order tempOrder = new Order { Id = 1 };
            foreach (var Order in _source.Orders)
            {
                if (Order.Id >= tempOrder.Id)
                {
                    tempOrder.Id = Order.Id + 1;
                }
            }
            _source.Orders.Add(CreateModel(model, tempOrder));
        }

        public void Update(OrderBindingModel model)
        {
            Order tmpOrder = null;
            foreach (var Order in _source.Orders)
            {
                if (Order.Id == model.Id)
                {
                    tmpOrder = Order;
                }
            }
            if (tmpOrder == null)
            {
                throw new Exception("Элемент не найден");
            }
            CreateModel(model, tmpOrder);
        }

        public void Delete(OrderBindingModel model)
        {
            for (int i = 0; i < _source.Orders.Count; ++i)
            {
                if (_source.Orders[i].Id == model.Id)
                {
                    _source.Orders.RemoveAt(i);
                    return;
                }
            }
            throw new Exception("Элемент не найден");
        }

        private Order CreateModel(OrderBindingModel model, Order order)
        {
            order.ShipId = model.ShipId;
            order.Count = model.Count;
            order.Status = model.Status;
            order.Sum = model.Sum;
            order.DateCreate = model.DateCreate;
            order.DateImplement = model.DateImplement;
            order.ClientId = (int)model.ClientId;
            order.ImplementerId = (int)model.ImplementerId;
            return order;
        }

        private OrderViewModel CreateModel(Order order)
        {
            string shipName = "";
            foreach (var ship in _source.Ships)
            {
                if (order.ShipId == ship.Id)
                {
                    shipName = ship.ShipName;
                    break;
                }
            }
            string clientFCs = null;
            foreach (Client client in _source.Clients)
            {
                if (order.ClientId == client.Id)
                {
                    clientFCs = client.ClientFCs;
                    break;
                }
            }
            string implementerFIO = null;
            foreach (Implementer implementer in _source.Implementers)
            {
                if (order.ImplementerId == implementer.Id)
                {
                    implementerFIO = implementer.ImplementerFIO;
                    break;
                }
            }
            return new OrderViewModel
            {
                Id = order.Id,
                ShipId = order.ShipId,
                ShipName = shipName,
                ClientId = order.ClientId,
                ClientFCs = clientFCs,
                ImplementerId = order.ImplementerId,
                ImplementerFIO = implementerFIO,
                Count = order.Count,
                Status = order.Status,
                Sum = order.Sum,
                DateCreate = order.DateCreate,
                DateImplement = order.DateImplement,
            };
        }
    }
}
