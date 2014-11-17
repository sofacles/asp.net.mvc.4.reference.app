using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BikeStore.Models
{
	public class OrderItemViewModel
	{
		public OrderItemViewModel()
		{
			OrderExists = false;
		}
		public string productID
		{
			get;
			set;
		}

		public string orderID
		{
			get;
			set;
		}

		public bool OrderExists
		{
			get;
			set;
		}


	}
}