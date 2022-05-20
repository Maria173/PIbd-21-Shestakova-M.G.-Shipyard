using System.Collections.Generic;
using ShipyardContracts.Attributes;

namespace ShipyardContracts.ViewModels
{
    public class ShipViewModel
    {
        [Column(title: "Номер", width: 80)]
        public int Id { get; set; }

        [Column(title: "Название изделия", width: 180)]
        public string ShipName { get; set; }

        [Column(title: "Цена", width: 60)]
        public decimal Price { get; set; }

        public Dictionary<int, (string, int)> ShipComponents { get; set; }
    }
}
