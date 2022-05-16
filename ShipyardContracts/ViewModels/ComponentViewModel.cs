using ShipyardContracts.Attributes;

namespace ShipyardContracts.ViewModels
{
    public class ComponentViewModel
    {
        [Column(title: "Номер", width: 80)]
        public int Id { get; set; }

        [Column(title: "Название компонента", gridViewAutoSize: GridViewAutoSize.Fill)]
        public string ComponentName { get; set; }
    }
}
