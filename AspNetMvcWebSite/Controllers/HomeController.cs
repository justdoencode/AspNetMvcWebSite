using AspNetMvcWebSite.DataAccessLayer;
using AspNetMvcWebSite.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvcWebSite.Controllers
{
    public class HomeController : Controller
    {

        DatabaseContext databaseContext = new DatabaseContext();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Books()
        {
            return View();
        }

        public ActionResult Blog()
        {
            return View();
        }


        //Kullanıcı Girişi
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string email, string password, string adminEmail, string adminPassword)
        {

            if (email != null)
            {
                var result = databaseContext.Users.Where(u => u.Eposta == email & u.Password == password).FirstOrDefault();
                if (result == null)
                {
                    return View("Login");
                }

                return View("Index");
            }
            else
            {
                var result = databaseContext.AdminUsers.Where(a => a.Eposta == adminEmail & a.Password == adminPassword).FirstOrDefault();
                if (result == null)
                {
                    return View("Login");
                }
                return View("AdminPage");
            }


        }


        //Kullanıcı Ekleme
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(string firstName, string lastName, string email, string password)
        {
            User newUser = new User();
            newUser.FirstName = firstName;
            newUser.LastName = lastName;
            newUser.Eposta = email;
            newUser.Password = password;

            databaseContext.Users.Add(newUser);
            databaseContext.SaveChanges();

            return View("Register");

        }

        public ActionResult AdminPage()
        {
            return View();
        }



        //Admin Section
        public PartialViewResult AdminAddBookSection()
        {
            return PartialView("_PartialPageAddBook");
        }


        public ActionResult AddBook()
        {
            return View();
        }
    }
}