using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App_Project.Models;
using System.Data.Entity;

namespace App_Project.Controllers
{
    public class ProjectsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetData()
        {
            using (PMS_DBEntities db = new PMS_DBEntities())
            {   
                List<tbl_Projects> projList = db.tbl_Projects.ToList<tbl_Projects>();
                return Json(new { data = projList }, JsonRequestBehavior.AllowGet);
            }
        }

        // its for insert and update , just projects/adOredit for add and  projects/adOredit/id for update opr
        [HttpGet]
        public ActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new tbl_Projects());
            else
            {
                using (PMS_DBEntities db = new PMS_DBEntities())
                {
                    return View(db.tbl_Projects.Where(x => x.Id == id).FirstOrDefault<tbl_Projects>());
                }
            }
        }   


        [HttpPost]
        public ActionResult AddOrEdit(tbl_Projects proj)
        {
            using (PMS_DBEntities db = new PMS_DBEntities())
            {
                if (proj.Id == 0)
                {   
                    db.tbl_Projects.Add(proj);
                    db.SaveChanges();
                    return Json(new { success = true, message = "Project has been  Saved Successfully" }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    db.Entry(proj).State = EntityState.Modified;
                    db.SaveChanges();
                    return Json(new { success = true, message = "Project has been Updated Successfully" }, JsonRequestBehavior.AllowGet);
                }
            }
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            using (PMS_DBEntities db = new PMS_DBEntities())
            {
                tbl_Projects proj = db.tbl_Projects.Where(x => x.Id == id).FirstOrDefault<tbl_Projects>();
                db.tbl_Projects.Remove(proj);
                db.SaveChanges();
                return Json(new { success = true, message = "Project has been Deleted Successfully" }, JsonRequestBehavior.AllowGet);
            }
        }

    }
}