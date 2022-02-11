using ShipyardContracts.BindingModels;
using ShipyardContracts.ViewModels;
using System.Collections.Generic;

namespace ShipyardContracts.BusinessLogicsContracts
{
    public interface IComponentLogic
    {
        List<ComponentViewModel> Read(ComponentBindingModel model);

        void CreateOrUpdate(ComponentBindingModel model);

        void Delete(ComponentBindingModel model);
    }
}
