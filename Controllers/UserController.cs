using online_coffee.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace online_coffee.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        OnlineCoffeeEntities3 database = new OnlineCoffeeEntities3();
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User cust)
        {
            if (ModelState.IsValid)
            {
                if (string.IsNullOrEmpty(cust.LoginName))
                    ModelState.AddModelError(string.Empty, "Tên đăng nhập không được để trống");
                if (string.IsNullOrEmpty(cust.Password))
                    ModelState.AddModelError(string.Empty, "Password không được để trống");
                var customer = database.Users.FirstOrDefault(k => k.LoginName == cust.LoginName);
                if (customer != null)
                {
                    ModelState.AddModelError(string.Empty, "Tên đăng nhập bị trùng");
                }
                if (ModelState.IsValid)
                {
                    database.Users.Add(cust);
                    database.SaveChanges();
                }
                else
                {
                    return View();
                }
            }
            return RedirectToAction("Login");
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User cust)
        {
            if (ModelState.IsValid)
            {
                if (string.IsNullOrEmpty(cust.LoginName))
                    ModelState.AddModelError(string.Empty, "Tên đăng nhập không được để trống");
                if (string.IsNullOrEmpty(cust.Password))
                    ModelState.AddModelError(string.Empty, "Password không được để trống");
                if (ModelState.IsValid)
                {
                    var customer = database.Users.FirstOrDefault(k => k.LoginName == cust.LoginName && k.Password == cust.Password);
                    if (customer != null)
                    {
                        //return View("Home");
                        Session["TaiKhoan"] = customer;
                        return RedirectToAction("Index", "Home");
                       
                    }
                    else
                        ViewBag.ThongBao = "Tên đăng nhập hoặc mật khẩu không đúng";
                }
            }
            return View();
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }
    }
}