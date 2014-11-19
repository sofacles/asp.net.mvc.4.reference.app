using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

namespace BikeStore.Models
{
	public class ProductListViewModel
	{
		public ProductListViewModel(List<Product> products) : this()
		{
			Products = products;
		}

		public ProductListViewModel()
		{
			OrderID = -1;
		}
		
		public List<Product> Products
		{
			get;
			set;
		}

		/// <summary>
		/// This will get a real value later.. not setting it initially in case user does not actually 
		/// add anything to cart
		/// </summary>
		
		public int OrderID
		{
			get;
			set;
		}
	}
}