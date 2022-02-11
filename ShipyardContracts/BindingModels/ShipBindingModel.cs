﻿using System.Collections.Generic;

namespace ShipyardContracts.BindingModels
{
    public class ShipBindingModel
    {
        public int? Id { get; set; }

        public string ShipName { get; set; }

        public decimal Price { get; set; }

        public Dictionary<int, (string, int)> ShipComponents { get; set; }
    }
}
