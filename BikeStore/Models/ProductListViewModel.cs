using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

namespace BikeStore.Models
{
	public class ProductListViewModel
	{
		public ProductListViewModel(List<Product> products)
		{
			Products = products;
		}
		
		public List<Product> Products
		{
			get;
			set;
		}

		/// <summary>
		/// May want to create this later, in case user does not actually add anything to cart
		/// </summary>
		private Guid orderID = Guid.Empty;
		public Guid OrderID
		{
			get
			{
				if (orderID == Guid.Empty)
				{
					orderID = Guid.NewGuid();
				}
				return orderID;
			}
		}
	}
}