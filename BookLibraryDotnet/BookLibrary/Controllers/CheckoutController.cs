using AspNetCoreHero.ToastNotification.Abstractions;
using BookLibrary.Extension;
using BookLibrary.Models;
using BookLibrary.ModelViews;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly dbBookLibraryContext _context;
        public INotyfService _notyfService { get; }

        public CheckoutController(dbBookLibraryContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }

        // Get Cart from Session
        private List<CartItem> GioHang => HttpContext.Session.Get<List<CartItem>>("GioHang") ?? new List<CartItem>();

        // GET: Checkout
        [Route("checkout.html", Name = "Checkout")]
        public IActionResult Index(string returnUrl = null)
        {
            var cart = GioHang;
            var taikhoanID = HttpContext.Session.GetString("CustomerId");
            var model = new MuaHangVM();

            // Check if customer is logged in and load their details
            if (!string.IsNullOrEmpty(taikhoanID))
            {
                var customer = _context.Customers.AsNoTracking().FirstOrDefault(x => x.CustomerId == Convert.ToInt32(taikhoanID));
                if (customer != null)
                {
                    model.CustomerId = customer.CustomerId;
                    model.FullName = customer.FullName;
                    model.Email = customer.Email;
                    model.Phone = customer.Phone;
                    model.Address = customer.Address;
                }
            }

            // Load provinces for selection
            ViewData["lsTinhThanh"] = new SelectList(
                _context.Locations
                        .Where(x => x.Levels == 1)
                        .OrderBy(x => x.Type),
                "LocationId",
                "Name"
            );

            // Pass cart to view
            ViewBag.GioHang = cart;
            return View(model);
        }

        // POST: Checkout
        [HttpPost]
        [Route("checkout.html", Name = "Checkout")]
        public IActionResult Index(MuaHangVM muaHang)
        {
            var cart = GioHang;
            var taikhoanID = HttpContext.Session.GetString("CustomerId");
            var model = new MuaHangVM();

            if (!string.IsNullOrEmpty(taikhoanID))
            {
                var customer = _context.Customers.AsNoTracking().FirstOrDefault(x => x.CustomerId == Convert.ToInt32(taikhoanID));
                if (customer != null)
                {
                    model.CustomerId = customer.CustomerId;
                    model.FullName = customer.FullName;
                    model.Email = customer.Email;
                    model.Phone = customer.Phone;
                    model.Address = customer.Address;

                    // Update customer info from the view model
                    customer.LocationId = muaHang.TinhThanh;
                    customer.District = muaHang.QuanHuyen;
                    customer.Ward = muaHang.PhuongXa;
                    customer.Address = muaHang.Address;

                    _context.Update(customer);
                    _context.SaveChanges();
                }

                if (ModelState.IsValid)
                {
                    if (cart != null && cart.Count > 0)
                    {
                        // Create order
                        var order = new Order
                        {
                            CustomerId = model.CustomerId,
                            OrderDate = DateTime.Now,
                            TransactStatusId = 1, // New order
                            Deleted = false,
                            Paid = false,
                            TotalMoney = (int?)cart.Sum(x => x.TotalMoney) // Use LINQ to sum
                        };

                        _context.Add(order);
                        _context.SaveChanges();

                        // Show success notification
                        _notyfService.Success("Đặt hàng thành công!");
                        return RedirectToAction("Success");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Giỏ hàng của bạn không có sản phẩm.");
                    }
                }
            }

            ViewBag.GioHang = cart;
            return View(model);
        }

        // GET: Success
        [Route("dat-hang-thanh-cong.html", Name = "Success")]
        public IActionResult Success()
        {
            return View();
        }

        private string GetNameLocation(int idLocation)
        {
            try
            {
                var location = _context.Locations.AsNoTracking().SingleOrDefault(x => x.LocationId == idLocation);
                return location?.NameWithType ?? string.Empty;
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
