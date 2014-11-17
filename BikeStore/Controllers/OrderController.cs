using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using BikeStore.Models;

namespace BikeStore.Controllers
{
    public class OrderController : Controller
    {
        private IOrderRepository orderRepository;

		public OrderController(IOrderRepository repo)
		{
			orderRepository = repo;
		}

		public OrderController()
			: this(new OrderRepository())
		{
		}
		
		//
		// POST: /Order/AddProductToOrder
		[HttpPost]
		public JsonResult AddProductToOrder(OrderItemViewModel orderItem)
        {
			Guid? newID;
			if (!orderItem.OrderExists)
			{
				string ip = Request.ServerVariables["REMOTE_ADDR"];
				newID = orderRepository.createOrderShell(ip);
			}

			Guid? orderItemID = orderRepository.UpdateItemQuantity(Guid.Parse(orderItem.productID),
																	Guid.Parse(orderItem.orderID), 1);
		   return Json(new { orderItemID = orderItemID ?? Guid.Empty });
        }

    }
}
