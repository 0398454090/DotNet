using BookLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BookLibrary.Controllers
{
    public class PageController : Controller
    {
        private readonly dbBookLibraryContext _context;

        public PageController(dbBookLibraryContext context)
        {
            _context = context;
        }

        // GET: /page/{Alias}
        [Route("/page/{Alias}", Name = "PageDetails")]
        public IActionResult Details(string Alias)
        {
            if (string.IsNullOrEmpty(Alias))
            {
                return RedirectToAction("Index", "Home");
            }

            // Truy vấn dữ liệu theo Alias
            var page = _context.Pages.AsNoTracking().SingleOrDefault(x => x.Alias == Alias);
            if (page == null)
            {
                // Nếu không tìm thấy, có thể trả về lỗi hoặc chuyển hướng
                return RedirectToAction("PageNotFound");
            }

            return View(page);
        }

        // Trang lỗi khi không tìm thấy alias
        public IActionResult PageNotFound()
        {
            return View();
        }
    }
}
