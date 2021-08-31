using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai2.Models;

namespace Bai2.Controllers
{
    public class GiaiPTB1Controller : Controller
    {
        GiaiphuongtrinhB1 gpt = new GiaiphuongtrinhB1(); 
        // GET: GiaiPTB1
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TinhNghiem()
        {
            return View();
        }
        [HttpPost]
        public ActionResult TinhNghiem(double hesoA, double hesoB)
        {
            double x = gpt.GiaiPTB1(hesoA, hesoB);
            ViewBag.nghiemPT = x;
            return View();
        }
    }
}