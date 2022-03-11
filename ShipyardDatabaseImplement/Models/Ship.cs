using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShipyardDatabaseImplement.Models
{
    public class Ship
    {
        public int Id { get; set; }
        [Required]
        public string ShipName { get; set; }
        [Required]
        public decimal Price { get; set; }

        [ForeignKey("ShipId")]
        public virtual List<ShipComponent> ShipComponents { get; set; }
        [ForeignKey("ShipId")]
        public virtual List<Order> Orders { get; set; }
    }
}