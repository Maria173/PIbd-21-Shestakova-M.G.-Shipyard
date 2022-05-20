using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShipyardContracts.Attributes;

namespace ShipyardContracts.ViewModels
{
    public class ClientViewModel
    {
        [Column(title: "Номер", width: 80)]
        public int Id { get; set; }
        [Column(title: "ФИО", gridViewAutoSize: GridViewAutoSize.Fill)]
        public string FCs { get; set; }
        [Column(title: "Логин", gridViewAutoSize: GridViewAutoSize.Fill)]
        public string Login { get; set; }
        [Column(title: "Пароль", gridViewAutoSize: GridViewAutoSize.Fill)]
        public string Password { get; set; }
    }
}