using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using BikeStore.Models;

namespace BikeStore.Controllers
{
    public class ProductController : Controller
    {
       
		private IProductRepository productRepository;

		public ProductController(IProductRepository repo)
		{
			productRepository = repo;
		}

		public ProductController() : this(new ProductRepository())
		{
		}

		//
		// GET: /Products/
        public ActionResult Products()
        {
			ProductListViewModel productListViewModel = new ProductListViewModel(
															productRepository.GetProducts());
			return View("List", productListViewModel);
        }

    }
}
