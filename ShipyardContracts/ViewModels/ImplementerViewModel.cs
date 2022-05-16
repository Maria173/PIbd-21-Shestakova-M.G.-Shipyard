using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShipyardContracts.Attributes;

namespace ShipyardContracts.ViewModels
{
    public class ImplementerViewModel
    {
        public int Id { get; set; }

        [Column(title: "ФИО", gridViewAutoSize: GridViewAutoSize.Fill)]
        public string ImplementerFIO { get; set; }

        [Column(title: "Время на заказ", width: 100)]
        public int WorkingTime { get; set; }

        [Column(title: "Время на перерыв", width: 100)]
        public int PauseTime { get; set; }
    }
}
