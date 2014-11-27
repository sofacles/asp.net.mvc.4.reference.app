using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
	public class OrderRepository : IOrderRepository
	{
		private KCStoreEntities11_17 BikeEntities = new KCStoreEntities11_17();

		public int? createOrderShell(string userIP)
		{
			return BikeEntities.Order_Create(userIP).FirstOrDefault();
		}

		public int? UpdateItemQuantity(int productID, int orderID, uint quantity)
		{
			return BikeEntities.OrderItem_AddOrUpdate(productID, (int)quantity, orderID).FirstOrDefault();
		}

		public void DeleteItem(int productID, int orderID)
		{
			BikeEntities.OrderItem_Remove(productID, orderID);
		}

		public int? UpdateShippingInfo(int orderID, string ipAddress, string name, string email, string shippingAddress, string phoneNumber)
		{
			return BikeEntities.Order_Update(orderID, name, email, shippingAddress, phoneNumber).FirstOrDefault();
		}

		public Order GetOrder(int orderID)
		{
			Order order = BikeEntities.Order_Select(orderID).FirstOrDefault();
			return order;
		}

		public List<OrderItem_Select_Result> GetOrderItems(int orderID)
		{
			List<OrderItem_Select_Result> orderItems = BikeEntities.OrderItem_Select(orderID).ToList();
			return orderItems;
		}

		public void SaveChanges()
		{
			BikeEntities.SaveChanges();
		}
	}
}
