using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai2.Models;

namespace Bai2.Controllers
{
    public class DemoController : Controller
    {
        GiaiPT gpt = new GiaiPT();

        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Hello()
        {
            return View();
        }
        public ActionResult GiaiPTB1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GiaiPTB1(double hesoA, double hesoB)
        {
            double x = gpt.GiaiPhuongTrinhBacNhat(hesoA, hesoB);
            ViewBag.nghiemPT = x;
            return View();
        }
    }
}