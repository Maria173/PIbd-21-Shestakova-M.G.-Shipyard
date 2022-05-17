namespace ShipyardContracts.BindingModels
{
    public class CreateOrderBindingModel
    {
        public int ShipId { get; set; }
        public int ClientId { get; set; }

        public int Count { get; set; }

        public decimal Sum { get; set; }
    }
}
