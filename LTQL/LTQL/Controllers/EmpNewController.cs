using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LTQL.Models;

namespace LTQL.Controllers
{
    public class EmpNewController : Controller
    {
        LTQLDbcontext db = new LTQLDbcontext();
        AutoGenerateKey genKey = new AutoGenerateKey();
        // GET: EmpNew
        public ActionResult Index()
        {
            return View(db.Employees.ToList());
        }
        public ActionResult Create()
        {
            var empID = "";
            var countEmployee = db.Employees.Count();
            if (countEmployee == 0)
            {
                empID = "ST001";
            }
            else
            {
                //Lấy giá trị PersonID moi nhat
                var PeopleID = db.Employees.ToList().OrderByDescending(m => m.PeopleID).FirstOrDefault().PeopleID;
                //sinh PersonID tự dộng
                empID = genKey.Generatekey(PeopleID);
            }
            ViewBag.PeopleID = empID;
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            var countEmployee = db.Employees.Count();
            if (countEmployee == 0)
            {
                emp.PeopleID = "ST001";
            }
            else
            {
                //Lấy giá trị PersonID moi nhat
                var PeopleID = db.Employees.ToList().OrderByDescending(m => m.PeopleID).FirstOrDefault().PeopleID;
                //sinh PersonID tự dộng
                emp.PeopleID = genKey.Generatekey(PeopleID);
            }
            //luu thông tin vao database
            db.Employees.Add(emp);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}

    
      