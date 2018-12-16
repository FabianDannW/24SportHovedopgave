using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _24SportWebkatalog.Controllers
{
    public class CatalogController : Controller
    {
        // GET: Catalog
        public ActionResult MainCatalog()
        {
            return View();
        }
    }
}