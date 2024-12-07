using BookLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using System.Linq;

namespace BookLibrary.Controllers
{
	public class ProductController : Controller
	{
		private readonly dbBookLibraryContext _context;
		public ProductController(dbBookLibraryContext context)
		{
			_context = context;
		}

        [Route("BookList.html", Name = "BookListProduct")]
        public IActionResult BookList(int? page)
        {
            try
            {
                var pageNumber = page == null || page <= 0 ? 1 : page.Value;
				var pageSize = 16;
                var tinDangs = _context.Products
                    .AsNoTracking()
                    .OrderByDescending(x => x.DateCreated);

                PagedList<Product> models = new PagedList<Product>(tinDangs, pageNumber, pageSize);
                ViewBag.CurrentPage = pageNumber;
              
                return View(models);
            }
            catch
            {
                return RedirectToAction("BookList", "Home");
            }
        }



        
        [Route("/{Alias}", Name = "ListProduct")]
		public IActionResult List(string Alias, int page = 1)
		{
			try
			{
				var pageSize = 16;
				var danhmuc = _context.Categories.AsNoTracking().SingleOrDefault(x => x.Alias == Alias);
				var tinDangs = _context.Products
					.AsNoTracking()
					.Where(x => x.CatId == danhmuc.CatId)
					.OrderByDescending(x => x.DateCreated);

				PagedList<Product> models = new PagedList<Product>(tinDangs, page, pageSize);
				ViewBag.CurrentPage = page;
				ViewBag.CurrentCat = danhmuc;
				return View(models);
			}
			catch
			{
				return RedirectToAction("BookList", "Home");
			}

		}

		[Route("/{Alias}--{id}.html", Name = "ProductDetails")]
		public IActionResult BookDetail(int id)
		{
			try
			{
				var product = _context.Products.Include(x => x.Cat).FirstOrDefault(x => x.ProductId == id);
				if (product == null)
				{
					return RedirectToAction("BookList");
				}
                var lsProduct = _context.Products
                    .AsNoTracking()
                    .Where(x => x.CatId == product.CatId && x.ProductId != id && x.Active == true)
                    .OrderByDescending(x => x.DateCreated)
                    .Take(4)
                    .ToList();

                ViewBag.SanPham = lsProduct;


                return View(product);
			}
			catch
			{
				return RedirectToAction("BookList", "Home");
			}
			
		}
	}
}
