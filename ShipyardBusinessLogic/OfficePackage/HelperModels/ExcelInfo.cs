using ShipyardContracts.ViewModels;
using System.Collections.Generic;

namespace ShipyardBusinessLogic.OfficePackage.HelperModels
{
    public class ExcelInfo
    {
        public string FileName { get; set; }
        public string Title { get; set; }
        public List<ReportShipComponentViewModel> ShipComponents { get; set; }
        public List<ReportWarehouseComponentViewModel> WarehouseComponents { get; set; }
    }
}
