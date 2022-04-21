using System.Collections.Generic;

namespace ShipyardFileImplement.Models
{
    public class Ship
    {
        public int Id { get; set; }

        public string ShipName { get; set; }

        public decimal Price { get; set; }

        public Dictionary<int, int> ShipComponents { get; set; }
    }
}
