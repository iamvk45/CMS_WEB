using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMS_WEB.Controllers
{
    public class CommonController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}