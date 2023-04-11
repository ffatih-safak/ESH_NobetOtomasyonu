using ESH_Business.Concrete;
using ESH_Entity.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ESH_Nobet.Controllers
{
    public class DoctorController : Controller 
    {
        // GET: Doctor
        DoctorManager doctorManager = new DoctorManager();
        DepartmanManager derpartmanManager = new DepartmanManager();
        public ActionResult Index()
        {
            var list = doctorManager.GetAll();
            return View(list);
        }
        [HttpGet]
        public ActionResult DoctorAdd()
        {
            return View(new EmployeeDoctor());
        }
        [HttpPost]
        public ActionResult DoctorAdd(EmployeeDoctor employeeDoctor)
        {
            doctorManager.DoctorAdd(employeeDoctor);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult DoctorUpdate(int id)
        {
            EmployeeDoctor dr= doctorManager.DoctorFind(id);
            return View(dr);
        }
        [HttpPost]
        public ActionResult DoctorUpdate(EmployeeDoctor employeeDoctor)
        {
            doctorManager.UpdateDoctor(employeeDoctor);
            return RedirectToAction("Index");
        }

        public ActionResult DoctorDelete(int id)
        {
            doctorManager.DeleteDoctor(id);
            return RedirectToAction("Index");
        }

    }
}