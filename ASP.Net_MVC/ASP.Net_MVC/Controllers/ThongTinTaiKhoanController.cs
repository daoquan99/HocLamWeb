using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.Net_MVC.Controllers
{
    public class ThongTinTaiKhoanController : Controller
    {
        // GET: ThongTinTaiKhoan
        [HttpGet]
        public ActionResult DangNhap()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ThongTinTaiKhoan(FormCollection collection,string HoTen)
        {
            ViewBag.HoTen = HoTen;
            ViewBag.TaiKhoan = collection.Get("txtTenDangNhap").ToString();
            return View();
        }
    }
}