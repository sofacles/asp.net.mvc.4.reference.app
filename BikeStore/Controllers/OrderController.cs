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
		[ValidateAntiForgeryToken]
		public JsonResult AddProductToOrder(OrderItemViewModel orderItemViewModel)
        {
			return UpdateItemQuantity(orderItemViewModel);
        }

		//
		// POST: /Order/AddProductToOrder
		[HttpPost]
		[ValidateAntiForgeryToken]
		public JsonResult RemoveProductFromOrder(OrderItemViewModel orderItemViewModel)
		{
			orderRepository.DeleteItem(orderItemViewModel.ProductID, orderItemViewModel.OrderID);
			return Json(new { DeletedProductID = orderItemViewModel.ProductID });
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
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
		[ValidateAntiForgeryToken]
		public JsonResult UpdateOrderItemQuantity(OrderItemViewModel orderItemViewModel)
		{
			return UpdateItemQuantity(orderItemViewModel);
		}

		//
		// GET: /Order/Cart
		[HttpGet]
		public ActionResult Cart(int orderID)
		{
			Order order = orderRepository.GetOrder(orderID);
			List<OrderItem_Select_Result> orderItems = orderRepository.GetOrderItems(orderID);

			//TODO: Maybe make an adapter object to convert from Entity objects to Viewmodels

			List<OrderItemViewModel> itemVMs = new List<OrderItemViewModel>();
			foreach (OrderItem_Select_Result orderItem in orderItems)
			{
				itemVMs.Add(new OrderItemViewModel(orderItem.productID, orderItem.orderID, 
												 orderItem.productName,  orderItem.price, orderItem.quantity));
			}
			ViewBag.OrderID = orderID;
			return View("Cart", itemVMs);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Checkout(CartViewModel cartVM)
		{
			Order order = orderRepository.GetOrder(cartVM.OrderID);
			orderRepository.UpdateShippingInfo(cartVM.OrderID, Request.ServerVariables["REMOTE_ADDR"],
				cartVM.CustomerName, cartVM.EmailAddress, cartVM.ShippingAddress, cartVM.PhoneNumber);

			return RedirectToAction("ThankYou", new { orderID = cartVM.OrderID });
		}

		//
		// GET: /Order/Checkout
		[HttpGet]
		public ActionResult Checkout(int orderID)
		{
			Order order = orderRepository.GetOrder(orderID);
			ViewBag.OrderID = orderID;
			CartViewModel cartVM = new CartViewModel(orderID, order.CustomerName, order.EmailAddress,
				order.ShippingAddress, order.PhoneNumber);
			return View("Checkout", cartVM);
		}


		//
		// GET: /Order/ThankYou
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
