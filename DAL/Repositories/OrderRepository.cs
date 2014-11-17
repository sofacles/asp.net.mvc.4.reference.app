using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
	public class OrderRepository : IOrderRepository
	{
		private KCStoreEntities11_16 BikeEntities = new KCStoreEntities11_16();

		public Guid? createOrderShell(string userIP)
		{
			return BikeEntities.Order_Create(userIP).FirstOrDefault();
		}

		public Guid? UpdateItemQuantity(Guid productID, Guid orderID, uint quantity)
		{
			return BikeEntities.OrderItem_AddOrUpdate(productID, (int)quantity, orderID).FirstOrDefault();
		}

		public Guid? DeleteItem(Guid productID, Guid orderID)
		{
			return BikeEntities.OrderItem_Remove(productID, orderID).FirstOrDefault();
		}

		public Guid? UpdateShippingInfo(Guid orderID, string ipAddress, string name, string email, string shippingAddress, string phoneNumber)
		{
			return BikeEntities.Order_Update(ipAddress, name, email, shippingAddress, phoneNumber).FirstOrDefault();
			
		}

		public void SaveChanges()
		{
			BikeEntities.SaveChanges();
		}
	}
}
