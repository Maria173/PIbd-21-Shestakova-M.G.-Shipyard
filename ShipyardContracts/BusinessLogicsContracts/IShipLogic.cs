using ShipyardContracts.BindingModels;
using ShipyardContracts.ViewModels;
using System.Collections.Generic;

namespace ShipyardContracts.BusinessLogicsContracts
{
    public interface IShipLogic
    {
        List<ShipViewModel> Read(ShipBindingModel model);

        void CreateOrUpdate(ShipBindingModel model);

        void Delete(ShipBindingModel model);
    }
}
