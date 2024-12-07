using AspNetCoreHero.ToastNotification.Abstractions;
using BookLibrary.Extension;
using BookLibrary.Models;
using BookLibrary.ModelViews;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using XAct;

namespace BookLibrary.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly dbBookLibraryContext _context;
        public INotyfService _notyfService { get; }
        public ShoppingCartController(dbBookLibraryContext context, INotyfService notifyService)
        {
            _context = context;
            _notyfService = notifyService;
        }

        // Thuộc tính GioHang để lấy giỏ hàng từ Session
        public List<CartItem> GioHang
        {
            get
            {
                var gh = HttpContext.Session.Get<List<CartItem>>("GioHang");

                if (gh == default(List<CartItem>))
                {
                    gh = new List<CartItem>();
                }
                return gh;
            }
        }
        [HttpPost]
        [Route("api/cart/add")]
        public IActionResult AddToCart(int productID, int? amount)
        {
            List<CartItem> gioHang = GioHang;

            try
            {
                // Check if the product is already in the cart
                CartItem item = gioHang.SingleOrDefault(p => p.product.ProductId == productID);

                if (item != null)
                {
                    // If the product exists, update the quantity
                    if (amount.HasValue)
                    {
                        item.amount = amount.Value;
                    }
                    else
                    {
                        item.amount++;  // Increase the quantity by 1
                    }
                }
                else
                {
                    // If the product does not exist in the cart, add it
                    Product product = _context.Products.SingleOrDefault(p => p.ProductId == productID);
                    item = new CartItem
                    {
                        amount = amount.HasValue ? amount.Value : 1,
                        product = product,
                    };
                    gioHang.Add(item);
                }

                // Save the updated cart in the session
                HttpContext.Session.Set<List<CartItem>>("GioHang", gioHang);
                _notyfService.Success("Sản phẩm đã được thêm vào giỏ hàng.");
                return Json(new { success = true });
            }
            catch
            {
                return Json(new { success = false });
            }
        }

        [HttpPost]
        [Route("api/cart/update")]
        public IActionResult UpdateCart(int productID, int amount)
        {
            var cart = GioHang;

            try
            {
                if (cart != null)
                {
                    // Tìm sản phẩm trong giỏ hàng
                    CartItem item = cart.SingleOrDefault(p => p.product.ProductId == productID);
                    if (item != null)
                    {
                        // Cập nhật số lượng nếu tìm thấy
                        item.amount = amount > 0 ? amount : 1;
                    }

                    // Lưu lại giỏ hàng vào session
                    HttpContext.Session.Set("GioHang", cart);
                    return Json(new { success = true });
                }

                return Json(new { success = false });
            }
            catch (Exception)
            {
                return Json(new { success = false });
            }
        }



        [HttpPost]
        [Route("api/cart/remove")]
        public JsonResult Remove(int productID)
        {
            try
            {
                // Lấy giỏ hàng từ Session
                List<CartItem> gioHang = HttpContext.Session.Get<List<CartItem>>("GioHang");

                // Kiểm tra nếu giỏ hàng có dữ liệu
                if (gioHang == null || gioHang.Count == 0)
                {
                    return Json(new { success = false, message = "Giỏ hàng trống" });
                }

                // Tìm sản phẩm trong giỏ hàng theo ID
                var item = gioHang.FirstOrDefault(p => p.product.ProductId == productID);

                if (item != null)
                {
                    // Xóa sản phẩm khỏi giỏ hàng
                    gioHang.Remove(item);
                    // Cập nhật lại giỏ hàng trong Session
                    HttpContext.Session.Set("GioHang", gioHang);
                    return Json(new { success = true });
                }
                else
                {
                    return Json(new { success = false, message = "Không tìm thấy sản phẩm trong giỏ hàng" });
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }


        [Route("cart.html", Name = "Cart")]
        public IActionResult Index()
        {
            return View(GioHang);
        }


    }
}
