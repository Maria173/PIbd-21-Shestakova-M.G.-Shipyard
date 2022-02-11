using ShipyardContracts.BindingModels;
using ShipyardContracts.ViewModels;
using System.Collections.Generic;

namespace ShipyardContracts.StoragesContracts
{
    public interface IShipStorage
    {
        List<ShipViewModel> GetFullList();

        List<ShipViewModel> GetFilteredList(ShipBindingModel model);

        ShipViewModel GetElement(ShipBindingModel model);

        void Insert(ShipBindingModel model);

        void Update(ShipBindingModel model);

        void Delete(ShipBindingModel model);
    }
}
