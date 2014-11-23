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
			return UpdateItemQuantity(orderItemViewModel);
        }

		private JsonResult UpdateItemQuantity(OrderItemViewModel orderItemViewModel)
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
																	(int)orderID, (uint)orderItemViewModel.Quantity);

			orderRepository.SaveChanges();
			return Json(new
			{
				orderItemID = orderItemID ?? -1,
				ordID = orderID ?? -1
			});
		}

		//
		// POST: /Order/UpdateOrderItemQuantity
		[HttpPost]
		public JsonResult UpdateOrderItemQuantity(OrderItemViewModel orderItemViewModel)
		{
			return UpdateItemQuantity(orderItemViewModel);
		}

		//
		// GET: /Products/
		[HttpGet]
		public ActionResult Cart(int orderID)
		{
			Order order = orderRepository.GetOrder(orderID);
			List<OrderItem_Select_Result> orderItems = orderRepository.GetOrderItems(orderID);


			CartViewModel cartVM = new CartViewModel(orderID, order.CustomerName, order.EmailAddress,
				order.ShippingAddress, order.PhoneNumber);
			
			cartVM.ItemViewModels = new List<OrderItemViewModel>();
			foreach (OrderItem_Select_Result orderItem in orderItems)
			{
				cartVM.ItemViewModels.Add(new OrderItemViewModel(orderItem.productID, orderItem.orderID, 
												 orderItem.productName,  orderItem.price, orderItem.quantity));
			}
			return View("Cart", cartVM);
		}

		[HttpPost]
		public ActionResult Cart(CartViewModel cartVM)
		{
			Order order = orderRepository.GetOrder(cartVM.OrderID);
			orderRepository.UpdateShippingInfo(cartVM.OrderID, Request.ServerVariables["REMOTE_ADDR"],
				cartVM.CustomerName, cartVM.EmailAddress, cartVM.ShippingAddress, cartVM.PhoneNumber);

			return RedirectToAction("ThankYou", new { orderID = cartVM.OrderID });
		}


		[HttpGet]
		public ActionResult ThankYou(int orderID)
		{
			Order order = orderRepository.GetOrder(orderID);
			CartViewModel cartVM = new CartViewModel(orderID, order.CustomerName, order.EmailAddress,
				order.ShippingAddress, order.PhoneNumber);
			return View("ThankYou", cartVM);
		}
    }
}
