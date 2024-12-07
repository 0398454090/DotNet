using BookLibrary.Models;
using BookLibrary.ModelViews;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using XAct;

namespace BookLibrary.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly dbBookLibraryContext _context;

        public HomeController(ILogger<HomeController> logger, dbBookLibraryContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            HomeViewVM model = new HomeViewVM();

            var lsproducts = _context.Products
                .AsNoTracking()
                .Where(x => x.Active == true && x.HomeFlag==true )
                .OrderByDescending(x => x.DateCreated)
                .ToList();

            List<ProductHomeVM> lsProductViews = new List<ProductHomeVM>();

            var lscats = _context.Categories
                .AsNoTracking()
                .Where(x => x.Published == true)
                .OrderByDescending(x => x.Ordering)
                .ToList();

            foreach (var item in lscats)
            {
                ProductHomeVM productHome = new ProductHomeVM();
                productHome.category = item;
                productHome.lsProducts = lsproducts.Where(x => x.CatId == item.CatId).ToList();
                lsProductViews.Add(productHome);
            }

            var pages = _context.Pages
             .AsNoTracking()
             .Where(x => x.Published == true)
             .OrderByDescending(x => x.CreateDate)
             .ToList();

            model.Products = lsProductViews;
            model.Pages = pages; 
  

            ViewBag.AllProducts = lsproducts;


            return View(model);

        }

        public IActionResult Contact()
        {
            return View();
        }
		public IActionResult About()
		{
			return View();
		}

		public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Search(string search)
        {
            
            if (string.IsNullOrEmpty(search))
            {
              
                var allProducts = _context.Products.ToList();
                return View(allProducts);
            }

            var foundProducts = _context.Products
                .Where(p => p.ProductName.Contains(search))  
                .ToList();

            return View(foundProducts);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

}
