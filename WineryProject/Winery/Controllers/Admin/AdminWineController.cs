using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Winery.Controllers.Admin
{
    public class AdminWineController : Controller
    {
        // GET: AdminWine
        public ActionResult Index()
        {
            return View();
        }
    }
}