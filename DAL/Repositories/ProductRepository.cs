using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
	class ProductRepository : IProductRepository
	{
		KCStoreEntities11_15 bikeEntities = new KCStoreEntities11_15();
		public List<Product> GetProducts()
		{
			return bikeEntities.Product_Select().ToList();
		}
	}
}
