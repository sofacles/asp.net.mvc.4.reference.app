﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
	public interface IProductRepository
	{
		List<Product> GetProducts();
	}
}
