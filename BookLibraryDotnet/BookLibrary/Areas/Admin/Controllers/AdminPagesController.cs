using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookLibrary.Models;
using PagedList.Core;
using BookLibrary.Helper;
using BookLibrary.Extension;
using System.IO;
using AspNetCoreHero.ToastNotification.Abstractions;

namespace BookLibrary.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminPagesController : Controller
    {
        private readonly dbBookLibraryContext _context;
        public INotyfService _notifyService { get; }

        public AdminPagesController(dbBookLibraryContext context, INotyfService notyfService)
        {
            _context = context;
            _notifyService = notyfService;
        }

        // GET: Admin/AdminPages
        public ActionResult Index(int? page)
        {
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = 20;

            var listPages = _context.Pages
                .AsNoTracking()
                .OrderByDescending(x => x.PageId);

            PagedList<Page> models = new PagedList<Page>(listPages, pageNumber, pageSize);

            ViewBag.CurrentPage = pageNumber;

            return View(models);
        }

        // GET: Admin/AdminPages/Details/5
        // GET: Admin/AdminPages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var page = await _context.Pages
                .FirstOrDefaultAsync(m => m.PageId == id);

            if (page == null)
            {
                return NotFound();
            }

            // Thêm đường dẫn đầy đủ cho ảnh nếu chỉ lưu tên file
            page.Thumb = $"assets/images/pages/{page.Thumb}";

            return View(page);
        }


        // GET: Admin/AdminPages/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/AdminPages/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PageId,PageName,Contents,Thumb,Published,Title,MetaDesc,MetaKey,Alias,CreateDate,Ordering")] Page page, Microsoft.AspNetCore.Http.IFormFile fthumb)
        {
            if (ModelState.IsValid)
            {
                // Xử lý upload ảnh (thumb)
                if (fthumb != null)
                {
                    string extension = Path.GetExtension(fthumb.FileName);
                    string imageName = Utilities.SEOUrl(page.PageName) + extension;

                    page.Thumb = await Utilities.UploadFile(fthumb, @"pages", imageName.ToLower());
                }
                if (string.IsNullOrEmpty(page.Thumb)) page.Thumb = "default.jpg";

                _context.Add(page);
                await _context.SaveChangesAsync();
                _notifyService.Success("Thêm thành công");
                return RedirectToAction(nameof(Index));
            }
            return View(page);
        }

        // GET: Admin/AdminPages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var page = await _context.Pages.FindAsync(id);
            if (page == null)
            {
                return NotFound();
            }
            return View(page);
        }

        // POST: Admin/AdminPages/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PageId,PageName,Contents,Thumb,Published,Title,MetaDesc,MetaKey,Alias,CreateDate,Ordering")] Page page, Microsoft.AspNetCore.Http.IFormFile fthumb)
        {
            if (id != page.PageId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // Kiểm tra và upload ảnh mới (nếu có)
                    if (fthumb != null)
                    {
                        string extension = Path.GetExtension(fthumb.FileName);
                        string imageName = Utilities.SEOUrl(page.PageName) + extension;
                        page.Thumb = await Utilities.UploadFile(fthumb, @"pages", imageName.ToLower());
                    }

                    // Cập nhật vào CSDL
                    if (string.IsNullOrEmpty(page.Thumb)) page.Thumb = "default.jpg";
                    page.Alias = Utilities.SEOUrl(page.PageName);
                    _context.Update(page);
                    await _context.SaveChangesAsync();
                    _notifyService.Success("Cập nhật thành công");
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PageExists(page.PageId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(page);
        }

        // GET: Admin/AdminPages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var page = await _context.Pages
                .FirstOrDefaultAsync(m => m.PageId == id);
            if (page == null)
            {
                return NotFound();
            }

            return View(page);
        }

        // POST: Admin/AdminPages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var page = await _context.Pages.FindAsync(id);
            _context.Pages.Remove(page);
            await _context.SaveChangesAsync();
            _notifyService.Success("Xóa thành công");

            return RedirectToAction(nameof(Index));
        }

        private bool PageExists(int id)
        {
            return _context.Pages.Any(e => e.PageId == id);
        }
    }
}
