using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _24SportWebkatalog.Controllers
{
    public class AddtocartController : Controller
    {
        // GET: AddToCart  
        public ActionResult Add(CatalogController mo)
        {

            if (Session["cart"] == null)
            {
                List<CatalogController> li = new List<CatalogController>();

                li.Add(mo);
                Session["cart"] = li;
                ViewBag.cart = li.Count();


                Session["count"] = 1;


            }
            else
            {
                List<CatalogController> li = (List<CatalogController>)Session["cart"];
                li.Add(mo);
                Session["cart"] = li;
                ViewBag.cart = li.Count();
                Session["count"] = Convert.ToInt32(Session["count"]) + 1;

            }
            return RedirectToAction("Index", "Home");


        }
    }
}