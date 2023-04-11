using ESH_Business.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ESH_Nobet.Controllers
{
    public class AuthorityController : Controller
    {
        AuthorityManager authorityManager = new AuthorityManager();
        public ActionResult Index()
        {
            var list = authorityManager.GetAll();
            return View(list);
        }
    }
}