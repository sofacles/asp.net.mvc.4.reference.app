using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BikeStore.Models
{
	public class CartViewModel
	{

		public CartViewModel(int orderID, string customerName, string email, string shippingAddress, 
			string phone)
		{
			CustomerName = customerName;
			EmailAddress = email;
			ShippingAddress = shippingAddress;
			PhoneNumber = phone;
			OrderID = orderID;
		}

		public CartViewModel()
		{
		}
		public string CustomerName
		{
			get;
			set;
		}

		
		public string EmailAddress
		{
			get;
			set;
		}

		
		public string ShippingAddress
		{
			get;
			set;
		}


		public string PhoneNumber
		{
			get;
			set;
		}

		public List<OrderItemViewModel> ItemViewModels
		{
			get;
			set;
		}

		public int OrderID
		{
			get;
			set;
		}
	 
	}
}