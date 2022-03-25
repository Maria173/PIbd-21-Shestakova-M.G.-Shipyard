using ShipyardContracts.ViewModels;
using System.Collections.Generic;

namespace ShipyardBusinessLogic.OfficePackage.HelperModels
{
    public class WordInfo
    {
        public string FileName { get; set; }
        public string Title { get; set; }
        public List<ShipViewModel> Ships { get; set; }
    }
}