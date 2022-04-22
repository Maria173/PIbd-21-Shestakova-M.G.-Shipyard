using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShipyardContracts.BindingModels;
using ShipyardContracts.ViewModels;

namespace ShipyardContracts.StoragesContracts
{
    public interface IWarehouseStorage
    {
        List<WarehouseViewModel> GetFullList();
        List<WarehouseViewModel> GetFilteredList(WarehouseBindingModel model);
        WarehouseViewModel GetElement(WarehouseBindingModel model);
        void Insert(WarehouseBindingModel model);
        void Update(WarehouseBindingModel model);
        void Delete(WarehouseBindingModel model);
        bool CheckBalance(Dictionary<int, int> components);
        bool WriteOffBalance(Dictionary<int, int> components);
    }
}
