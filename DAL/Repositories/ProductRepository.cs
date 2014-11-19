using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
	public class ProductRepository : IProductRepository
	{
		KCStoreEntities11_17 bikeEntities = new KCStoreEntities11_17();
		public List<Product> GetProducts()
		{
			return bikeEntities.Product_Select().ToList();
		}
	}
}
