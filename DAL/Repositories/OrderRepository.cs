using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
	class OrderRepository : IOrderRepository
	{
		private KCStoreEntities11_15 BikeEntities = new KCStoreEntities11_15();

		public Guid? createOrderShell(string userIP)
		{
			return BikeEntities.Order_Create(userIP).FirstOrDefault();
		}

		public Guid? UpdateItemQuantity(Guid productID, Guid orderID, uint quantity, string ipAddress)
		{
			return BikeEntities.OrderItem_AddOrUpdate(ipAddress, productID, (int)quantity, orderID).FirstOrDefault();
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
