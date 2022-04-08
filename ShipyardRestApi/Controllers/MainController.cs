using ShipyardContracts.BindingModels;
using ShipyardContracts.BusinessLogicsContracts;
using ShipyardContracts.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ShipyardRestApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly IOrderLogic order;
        private readonly IShipLogic ship;
        public MainController(IOrderLogic order, IShipLogic ship)
        {
            this.order = order;
            this.ship = ship;
        }
        [HttpGet]
        public List<ShipViewModel> GetShipList() => ship.Read(null)?.ToList();
        [HttpGet]
        public ShipViewModel GetShip(int shipId) => ship.Read(new ShipBindingModel { Id = shipId })?[0];
        [HttpGet]
        public List<OrderViewModel> GetOrders(int clientId) => order.Read(new OrderBindingModel { ClientId = clientId });
        [HttpPost]
        public void CreateOrder(CreateOrderBindingModel model) =>
        order.CreateOrder(model);
    }

}