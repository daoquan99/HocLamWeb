using ASP.Net_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.Net_MVC.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection f)
        {
            return View();
        }

        [HttpGet]
        public ViewResult Demo()
        {
            List<TinhThanhPho> listTTP = new List<TinhThanhPho>();
            TinhThanhPho ttp;
            ttp = new TinhThanhPho();
            ttp.MaTinhThanhPho = 1;
            ttp.TenTinhThanhPho = "TP Ho Chi Minh";
            listTTP.Add(ttp);

            ttp = new TinhThanhPho();
            ttp.MaTinhThanhPho = 2;
            ttp.TenTinhThanhPho = "TP Ha Noi";
            listTTP.Add(ttp);

            ViewBag.TinhThanhPho = new SelectList(listTTP, "MaTinhThanhPho", "TenTinhThanhPho");
            return View();
        }
        [HttpPost]
        public ActionResult Demo(FormCollection f)
        {
           
            return View();
        }
        public string Demo12(string str)
        {
            return str;
        }
    }
}