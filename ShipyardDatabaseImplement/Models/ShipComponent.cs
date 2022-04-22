using System.ComponentModel.DataAnnotations;

namespace ShipyardDatabaseImplement.Models
{
    public class ShipComponent
    {
        public int Id { get; set; }
        public int ShipId { get; set; }
        public int ComponentId { get; set; }
        [Required]
        public int Count { get; set; }
        public virtual Component Component { get; set; }
        public virtual Ship Ship { get; set; }
    }
}
