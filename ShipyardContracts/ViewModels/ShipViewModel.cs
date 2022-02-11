using System.Collections.Generic;
using System.ComponentModel;

namespace ShipyardContracts.ViewModels
{
    public class ShipViewModel
    {
        public int Id { get; set; }

        [DisplayName("Название изделия")]
        public string ShipName { get; set; }

        [DisplayName("Цена")]
        public decimal Price { get; set; }

        public Dictionary<int, (string, int)> ShipComponents { get; set; }
    }
}
