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
        private readonly IMessageInfoLogic message;
        public MainController(IOrderLogic order, IShipLogic ship, IMessageInfoLogic message)
        {
            this.order = order;
            this.ship = ship;
            this.message = message;
        }
        [HttpGet]
        public List<ShipViewModel> GetShipList() => ship.Read(null)?.ToList();
        [HttpGet]
        public ShipViewModel GetShip(int shipId) => ship.Read(new ShipBindingModel { Id = shipId })?[0];
        [HttpGet]
        public List<OrderViewModel> GetOrders(int clientId) => order.Read(new OrderBindingModel { ClientId = clientId });
        [HttpGet]
        public List<MessageInfoViewModel> GetMessages() => message.Read(null)?.ToList();
        [HttpPost]
        public void CreateOrder(CreateOrderBindingModel model) =>
        order.CreateOrder(model);
    }

}