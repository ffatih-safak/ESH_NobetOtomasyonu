using ESH_Business.Concrete;
using ESH_Entity.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ESH_Nobet.Controllers
{
    public class DepartmantController : Controller
    {
        DepartmanManager derpartmanManager = new DepartmanManager();
        public ActionResult Index()
        {
            var list = derpartmanManager.GetAll();
            return View(list);
        }
        [HttpGet]
        public ActionResult  DepartmantAdd()
        {
            return View(new DepartmanHospital());
        }
        [HttpPost]
        public ActionResult DepartmantAdd(DepartmanHospital departmanHospital)
        {
            derpartmanManager.DepartmanAdd(departmanHospital);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult DepartmantUpdate(int id)
        {
            DepartmanHospital dr = derpartmanManager.DepartmanFind(id);
            return View(dr);
        }
        [HttpPost]
        public ActionResult DepartmantUpdate(DepartmanHospital departmanHospital)
        {
            derpartmanManager.UpdateDepartmant(departmanHospital);
            return RedirectToAction("Index");
        }

        public ActionResult DepartmantDelete(int id)
        {
            derpartmanManager.DeleteDepartman(id);
            return RedirectToAction("Index");
        }
    }
}