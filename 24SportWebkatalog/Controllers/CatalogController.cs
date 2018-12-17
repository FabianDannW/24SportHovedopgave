using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _24SportWebkatalog.Models;

namespace _24SportWebkatalog.Controllers
{
    public class CatalogController : Controller
    {
        // GET: Catalog
        public ActionResult MainCatalog()
        {

            using (OurdbContext db = new OurdbContext())
            {
                //Fejl her
                return View(db.catalogItems.ToList());
                //return View();
            }
        }
    }
}