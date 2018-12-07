using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App_Project.Models;
using System.Data.Entity;

namespace App_Project.Controllers
{

    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }




        public ActionResult GetData()
        {
            using (PMS_DBEntities db = new PMS_DBEntities())
            {
                List<tbl_Employee> empList = db.tbl_Employee.ToList<tbl_Employee>();
                return Json(new { data = empList }, JsonRequestBehavior.AllowGet);
            }
        }


        [HttpGet]
        public ActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new tbl_Employee());
            else
            {
                using (PMS_DBEntities db = new PMS_DBEntities())
                {
                    return View(db.tbl_Employee.Where(x => x.EmployeeID == id).FirstOrDefault<tbl_Employee>());
                }
            }
        }


        [HttpPost]
        public ActionResult AddOrEdit(tbl_Employee emp)
        {   
            using (PMS_DBEntities db = new PMS_DBEntities())
            {
                if (emp.EmployeeID == 0)
                {
                    db.tbl_Employee.Add(emp);
                    db.SaveChanges();
                    return Json(new { success = true, message = "Employee has been  Saved Successfully" }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    db.Entry(emp).State = EntityState.Modified;
                    db.SaveChanges();
                    return Json(new { success = true, message = "Employee has been Updated Successfully" }, JsonRequestBehavior.AllowGet);
                }
            }
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            using (PMS_DBEntities db = new PMS_DBEntities())
            {
                tbl_Employee emp = db.tbl_Employee.Where(x => x.EmployeeID == id).FirstOrDefault<tbl_Employee>();
                db.tbl_Employee.Remove(emp);
                db.SaveChanges();
                return Json(new { success = true, message = "Employee has been Deleted Successfully" }, JsonRequestBehavior.AllowGet);
            }
        }



    }
}
