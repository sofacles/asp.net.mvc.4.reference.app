using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
	public interface IOrderRepository
	{
		int? createOrderShell(string userIP);
		int? UpdateItemQuantity(int productID, int orderID, uint quantity);
		void DeleteItem(int productID, int orderID);
		int? UpdateShippingInfo(int orderID, string ipAddress, string name, string email, string shippingAddress, string phoneNumber);
		void SaveChanges();
	}
}
