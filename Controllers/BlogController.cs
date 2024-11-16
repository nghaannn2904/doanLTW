using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace online_coffee.Controllers
{
    public class BlogController : Controller
    {
        public ActionResult Index()
        {
            return View("Blog");
        }
        public ActionResult Blog()
        {
            return View();
        }
        public ActionResult Text1()
        {
            return View();
        }
        public ActionResult Text2()
        {
            return View();
        }
        public ActionResult Text3()
        {
            return View();
        }
        public ActionResult Text4()
        {
            return View();
        }
        public ActionResult Text5()
        {
            return View();
        }
    }
}