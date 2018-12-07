using App_Project.Models;
using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App_Project.Controllers
{
    public class ReportsController : Controller
    {

        PMS_DBEntities db = new PMS_DBEntities();


        public ActionResult EmpReport()
        {

            return View(db.tbl_Employee.ToList());
        }

        public ActionResult CrystalReport()
        {
            ReportDocument rd = new ReportDocument();
            rd.Load(Path.Combine(Server.MapPath("~/ReportsSection"), "EmployeeReport.rpt"));
            rd.SetDataSource(db.tbl_Employee.ToList());
            Response.Buffer = false;
            Response.ClearContent();
            Response.ClearHeaders();
            try
            {
                Stream stream = rd.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
                stream.Seek(0, SeekOrigin.Begin);
                return File(stream, "application/pdf", "Employees.pdf");
            }
            catch
            {
                throw;
            }
        }




        public ActionResult ProjReport()
        {

            return View(db.tbl_Projects.ToList());
        }

        public ActionResult ProjectReport()
        {
            ReportDocument rd = new ReportDocument();
            rd.Load(Path.Combine(Server.MapPath("~/ReportsSection"), "ProjectReport.rpt"));
            rd.SetDataSource(db.tbl_Projects.ToList());
            Response.Buffer = false;
            Response.ClearContent();
            Response.ClearHeaders();
            try
            {
                Stream stream = rd.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
                stream.Seek(0, SeekOrigin.Begin);
                return File(stream, "application/pdf", "ProjectReport.pdf");
            }
            catch
            {
                throw;
            }
        }








    }
}