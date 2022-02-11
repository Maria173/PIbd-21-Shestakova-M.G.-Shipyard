using ShipyardContracts.BindingModels;
using ShipyardContracts.BusinessLogicsContracts;
using ShipyardContracts.StoragesContracts;
using ShipyardContracts.ViewModels;
using System;
using System.Collections.Generic;

namespace ShipyardBusinessLogic.BusinessLogics
{
    public class ShipLogic : IShipLogic
    {
        private readonly IShipStorage _shipStorage;

        public ShipLogic(IShipStorage shipStorage)
        {
            _shipStorage = shipStorage;
        }

        public List<ShipViewModel> Read(ShipBindingModel model)
        {
            if (model == null)
            {
                return _shipStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<ShipViewModel> { _shipStorage.GetElement(model) };
            }
            return _shipStorage.GetFilteredList(model);
        }

        public void CreateOrUpdate(ShipBindingModel model)
        {
            var element = _shipStorage.GetElement(new ShipBindingModel { ShipName = model.ShipName });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть изделие с таким названием");
            }
            if (model.Id.HasValue)
            {
                _shipStorage.Update(model);
            }
            else
            {
                _shipStorage.Insert(model);
            }
        }

        public void Delete(ShipBindingModel model)
        {
            var element = _shipStorage.GetElement(new ShipBindingModel { Id = model.Id });
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            _shipStorage.Delete(model);
        }
    }
}
