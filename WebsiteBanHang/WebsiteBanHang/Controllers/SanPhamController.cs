using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanHang.Models;

namespace WebsiteBanHang.Controllers
{
    public class SanPhamController : Controller
    {
        QuanLyBanHangEntities db = new QuanLyBanHangEntities();
        // GET: SanPham
        public ActionResult SanPham1()
        {
            var lstSanPhamLPMoi = db.SanPhams.Where(x => x.MaLoaiSP == 2 && x.Moi == 1);
            ViewBag.lstSP = lstSanPhamLPMoi;

            return View();
        }
        public ActionResult SanPham2()
        {
            var lstSanPhamLPMoi = db.SanPhams.Where(x => x.MaLoaiSP == 2 && x.Moi == 1);
            ViewBag.lstSP = lstSanPhamLPMoi;
            return View();
        }
        [ChildActionOnly]
        public ActionResult SanPhamPartial()
        {
            var lstSanPhamLPMoi = db.SanPhams.Where(x => x.MaLoaiSP == 2 && x.Moi == 1);
            return PartialView(lstSanPhamLPMoi);
        }

        public ActionResult SanPhamStyle1Partial()
        {
            return PartialView();
        }
        public ActionResult SanPhamStyle2Partial()
        {
            return PartialView();
        }
    }
}