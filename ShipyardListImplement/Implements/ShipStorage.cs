using ShipyardContracts.BindingModels;
using ShipyardContracts.StoragesContracts;
using ShipyardContracts.ViewModels;
using ShipyardListImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShipyardListImplement.Implements
{
    public class ShipStorage : IShipStorage
    {
        private readonly DataListSingleton _source;

        public ShipStorage()
        {
            _source = DataListSingleton.GetInstance();
        }

        public List<ShipViewModel> GetFullList()
        {
            var result = new List<ShipViewModel>();
            foreach (var component in _source.Ships)
            {
                result.Add(CreateModel(component));
            }
            return result;
        }

        public List<ShipViewModel> GetFilteredList(ShipBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            var result = new List<ShipViewModel>();
            foreach (var ship in _source.Ships)
            {
                if (ship.ShipName.Contains(model.ShipName))
                {
                    result.Add(CreateModel(ship));
                }
            }
            return result;
        }

        public ShipViewModel GetElement(ShipBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            foreach (var ship in _source.Ships)
            {
                if (ship.Id == model.Id || ship.ShipName == model.ShipName)
                {
                    return CreateModel(ship);
                }
            }
            return null;
        }

        public void Insert(ShipBindingModel model)
        {
            var tempShip = new Ship
            {
                Id = 1,
                ShipComponents = new Dictionary<int, int>()
            };
            foreach (var ship in _source.Ships)
            {
                if (ship.Id >= tempShip.Id)
                {
                    tempShip.Id = ship.Id + 1;
                }
            }
            _source.Ships.Add(CreateModel(model, tempShip));
        }

        public void Update(ShipBindingModel model)
        {
            Ship tempShip = null;
            foreach (var ship in _source.Ships)
            {
                if (ship.Id == model.Id)
                {
                    tempShip = ship;
                }
            }
            if (tempShip == null)
            {
                throw new Exception("Элемент не найден");
            }
            CreateModel(model, tempShip);
        }

        public void Delete(ShipBindingModel model)
        {
            for (int i = 0; i < _source.Ships.Count; ++i)
            {
                if (_source.Ships[i].Id == model.Id)
                {
                    _source.Ships.RemoveAt(i);
                    return;
                }
            }
            throw new Exception("Элемент не найден");
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
                    ship.ShipComponents[component.Key] = model.ShipComponents[component.Key].Item2;
                }
                else
                {
                    ship.ShipComponents.Add(component.Key, model.ShipComponents[component.Key].Item2);
                }
            }
            return ship;
        }

        private ShipViewModel CreateModel(Ship ship)
        {
            // требуется дополнительно получить список компонентов для изделия с названиями и их количество
            var shipComponents = new Dictionary<int, (string, int)>();
            foreach (var pc in ship.ShipComponents)
            {
                string componentName = string.Empty;
                foreach (var component in _source.Components)
                {
                    if (pc.Key == component.Id)
                    {
                        componentName = component.ComponentName;
                        break;
                    }
                }
                shipComponents.Add(pc.Key, (componentName, pc.Value));
            }
            return new ShipViewModel
            {
                Id = ship.Id,
                ShipName = ship.ShipName,
                Price = ship.Price,
                ShipComponents = shipComponents
            };
        }
    }
}
