using BookLibrary.Extension;
using BookLibrary.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using BookLibrary.Helper;
using BookLibrary.ModelViews;
using Microsoft.AspNetCore.Authentication;
using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using AspNetCoreHero.ToastNotification.Abstractions;

namespace BookLibrary.Controllers
{
    [Authorize]
    public class AccountsController : Controller
    {
        private readonly dbBookLibraryContext _context;
        public INotyfService _notyfyService { get; }

        public AccountsController(dbBookLibraryContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfyService = notyfService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> ValidatePhone(string phone)
        {
            try
            {
                var khachhang = await _context.Customers
                    .AsNoTracking()
                    .SingleOrDefaultAsync(x => x.Phone.ToLower() == phone.ToLower());

                if (khachhang != null)
                    return Json($"Số điện thoại: {phone} đã được sử dụng");

                return Json(true);
            }
            catch (Exception ex)
            {
                _notyfyService.Error($"Lỗi: {ex.Message}");
                return Json(true);
            }
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> ValidateEmail(string email)
        {
            try
            {
                var khachhang = await _context.Customers
                    .AsNoTracking()
                    .SingleOrDefaultAsync(x => x.Email.ToLower() == email.ToLower());

                if (khachhang != null)
                    return Json($"Email: {email} đã được sử dụng");

                return Json(true);
            }
            catch (Exception ex)
            {
                _notyfyService.Error($"Lỗi: {ex.Message}");
                return Json(true);
            }
        }

        [Route("tai-khoan-cua-toi.html", Name = "Dashboard")]
        public async Task<IActionResult> Dashboard()
        {
            var taikhoanID = HttpContext.Session.GetString("CustomerId");
            if (taikhoanID != null)
            {
                var khachhang = await _context.Customers
                    .AsNoTracking()
                    .SingleOrDefaultAsync(x => x.CustomerId == Convert.ToInt32(taikhoanID));

                if (khachhang != null)
                {
                    var lsDonHang = await _context.Orders
                        .Include(x => x.TransactStatus)
                        .AsNoTracking()
                        .Where(x => x.CustomerId == khachhang.CustomerId)
                        .OrderByDescending(x => x.OrderDate)
                        .ToListAsync();

                    ViewBag.DonHang = lsDonHang;
                    return View(khachhang);
                }
            }

            return RedirectToAction("Login");
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("dang-ky.html", Name = "DangKy")]
        public IActionResult DangKyTaiKhoan()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("dang-ky.html", Name = "DangKy")]
        public async Task<IActionResult> DangKyTaiKhoan(RegisterVM taikhoan)
        {
            if (!ModelState.IsValid)
                return View(taikhoan);

            try
            {
                string salt = Utilities.GetRandomKey();
                Customer khachhang = new Customer
                {
                    FullName = taikhoan.FullName,
                    Phone = taikhoan.Phone.Trim().ToLower(),
                    Email = taikhoan.Email.Trim().ToLower(),
                    Password = (taikhoan.Password + salt.Trim()).ToMD5(),
                    Active = true,
                    Salt = salt,
                    CreateDate = DateTime.Now
                };

                _context.Add(khachhang);
                await _context.SaveChangesAsync();

                HttpContext.Session.SetString("CustomerId", khachhang.CustomerId.ToString());
                var taikhoanID = HttpContext.Session.GetString("CustomerId");

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, khachhang.FullName),
                    new Claim("CustomerId", khachhang.CustomerId.ToString())
                };

                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "login");
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                await HttpContext.SignInAsync(claimsPrincipal);

                _notyfyService.Success("Đăng ký thành công");
                return RedirectToAction("Dashboard", "Accounts");
            }
            catch (Exception ex)
            {
                _notyfyService.Error($"Có lỗi xảy ra: {ex.Message}");
                return RedirectToAction("DangKyTaiKhoan", "Accounts");
            }
        }

        [AllowAnonymous]
        [Route("dang-nhap.html", Name = "DangNhap")]
        public IActionResult Login(string returnUrl = null)
        {
            var taikhoanID = HttpContext.Session.GetString("CustomerId");
            if (taikhoanID != null)
                return RedirectToAction("Dashboard", "Accounts");

            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("dang-nhap.html", Name = "DangNhap")]
        public async Task<IActionResult> Login(LoginViewModel customer, string returnUrl = null)
        {
            if (!ModelState.IsValid)
                return View(customer);

            try
            {
                bool isEmail = Utilities.IsValidEmail(customer.UserName);
                if (!isEmail)
                    return View(customer);

                var khachhang = await _context.Customers
                    .AsNoTracking()
                    .SingleOrDefaultAsync(x => x.Email.Trim() == customer.UserName);

                if (khachhang == null)
                    return RedirectToAction("DangKyTaiKhoan");

                string pass = (customer.Password + khachhang.Salt.Trim()).ToMD5();
                if (khachhang.Password != pass)
                {
                    _notyfyService.Error("Thông tin đăng nhập sai");
                    return View(customer);
                }

                if (khachhang.Active == false)
                    return RedirectToAction("ThongBao", "Accounts");

                HttpContext.Session.SetString("CustomerId", khachhang.CustomerId.ToString());

                var taikhoanID = HttpContext.Session.GetString("CustomerId");
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, khachhang.FullName),
                    new Claim("CustomerId", khachhang.CustomerId.ToString())
                };

                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "login");
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                await HttpContext.SignInAsync(claimsPrincipal);

                _notyfyService.Success("Đăng nhập thành công");
                return RedirectToAction("Dashboard", "Accounts");
            }
            catch (Exception ex)
            {
                _notyfyService.Error($"Lỗi: {ex.Message}");
                return RedirectToAction("DangKyTaiKhoan", "Accounts");
            }
        }

        [HttpGet]
        [Route("dang-xuat.html", Name = "DangXuat")]
        public async Task<IActionResult> DangXuat()
        {
            await HttpContext.SignOutAsync();
            HttpContext.Session.Remove("CustomerId");
            return RedirectToAction("Login");
        }
    }
}
