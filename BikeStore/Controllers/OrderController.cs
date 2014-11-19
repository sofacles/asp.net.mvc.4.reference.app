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
		public JsonResult AddProductToOrder(OrderItemViewModel orderItemViewModel)
        {
			int? orderID = -1;
			if (orderItemViewModel.orderID == -1)
			{
				string ip = Request.ServerVariables["REMOTE_ADDR"];
				orderID = orderRepository.createOrderShell(ip);

			}
			else
			{
				orderID = orderItemViewModel.orderID;
			}

			int? orderItemID = orderRepository.UpdateItemQuantity(orderItemViewModel.productID,
																	(int)orderID, 1);

			orderRepository.SaveChanges();
		   return Json(new { orderItemID = orderItemID ?? -1,
								ordID = orderID ?? -1});
        }

    }
}
