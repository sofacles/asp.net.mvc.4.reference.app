using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
	public interface IOrderRepository
	{
		Guid? createOrderShell(string userIP);
		Guid? UpdateItemQuantity(Guid productID, Guid orderID, uint quantity);
		Guid? DeleteItem(Guid productID, Guid orderID);
		Guid? UpdateShippingInfo(Guid orderID, string ipAddress, string name, string email, string shippingAddress, string phoneNumber);
		void SaveChanges();
	}
}
