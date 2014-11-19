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
			if (orderItemViewModel.OrderID == -1)
			{
				string ip = Request.ServerVariables["REMOTE_ADDR"];
				orderID = orderRepository.createOrderShell(ip);

			}
			else
			{
				orderID = orderItemViewModel.OrderID;
			}

			int? orderItemID = orderRepository.UpdateItemQuantity(orderItemViewModel.ProductID,
																	(int)orderID, 1);

			orderRepository.SaveChanges();
		   return Json(new { orderItemID = orderItemID ?? -1,
								ordID = orderID ?? -1});
        }

		//
		// GET: /Products/
		public ActionResult Cart(int orderID)
		{
			Order order = orderRepository.GetOrder(orderID);
			List<OrderItem_Select_Result> orderItems = orderRepository.GetOrderItems(orderID);


			CartViewModel cartVM = new CartViewModel();
			cartVM.CustomerName = order.CustomerName;
			cartVM.EmailAddress = order.EmailAddress;
			cartVM.ShippingAddress = order.ShippingAddress;
			cartVM.EmailAddress = order.EmailAddress;
			cartVM.ItemViewModels = new List<OrderItemViewModel>();
			foreach (OrderItem_Select_Result orderItem in orderItems)
			{
				cartVM.ItemViewModels.Add(new OrderItemViewModel(orderItem.id, orderItem.orderID, 
												 orderItem.productName, string.Format("C", orderItem.price), orderItem.quantity));
			}
			return View("Cart", cartVM);
		}


    }
}
