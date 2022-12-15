using CMS_WEB.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CMS_WEB.Controllers
{
    public class DashboardController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}