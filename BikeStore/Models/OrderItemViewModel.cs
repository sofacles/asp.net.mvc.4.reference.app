using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace BikeStore.Models
{
	public class OrderItemViewModel
	{
		public OrderItemViewModel()
		{
			Quantity = 0;
		}

		public int ProductID
		{
			get;
			set;
		}

		public OrderItemViewModel(int productID, int orderID, string productName, decimal price, int quantity = 0)
		{
			ProductID = productID;
			OrderID = orderID;
			Quantity = quantity;
			ProductName = productName;
			Price = price;
		}

		public int OrderID
		{
			get;
			set;
		}

		public int Quantity
		{
			get;
			set;
		}
		public string ProductName
		{
			get;
			set;
		}

		[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:c}")]
		public decimal Price
		{
			get;
			set;
		}

	}
}