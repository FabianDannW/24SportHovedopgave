using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _24SportWebkatalog.Models;


namespace _24SportWebkatalog.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            using (Model1 db = new Model1())
            {
                return View(db.userinfoes.ToList());
            }
        }
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(userinfo account)
        {
            if (ModelState.IsValid)
            {
                using (Model1 db = new Model1())
                {
                    db.userinfoes.Add(account);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = account.firstname + " " + account.lastname + " successfully registered.";
            }
            return View();
        }

        //Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(userinfo user)
        {
            using (Model1 db = new Model1())
            {
                var usr = db.userinfoes.Where(u => u.Username == user.Username && u.Password == user.Password).FirstOrDefault();
                if (usr != null)
                {
                    Session["UserID"] = usr.UserID.ToString();
                    Session["Username"] = usr.Username.ToString();
                    return RedirectToAction("../Catalog/MainCatalog");
                }
                else
                {
                    ModelState.AddModelError("", "Username or password is wrong");
                }
            }
            return View();
        }

        public ActionResult Loggedin()
        {
            if (Session["UserID"] !=null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }


    }
}