using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShipyardContracts.ViewModels;
using ShipyardContracts.BindingModels;

namespace ShipyardContracts.BusinessLogicsContracts
{
    public interface IWarehouseLogic
    {
        List<WarehouseViewModel> Read(WarehouseBindingModel model);
        void CreateOrUpdate(WarehouseBindingModel model);
        void Delete(WarehouseBindingModel model);
        void AddComponent(WarehouseBindingModel model, int componentId, int Count);
    }
}
