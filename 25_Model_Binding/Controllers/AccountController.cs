using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _25_Model_Binding.Models;

namespace _25_Model_Binding.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }


        //Primitive model binding

        //[HttpPost]
        //public ContentResult Login(string username, string password)
        //{
        //    if(username == "scott" && password == "tiger")
        //    {
        //        return Content("Welcome scott");
        //    }else
        //    {
        //        return Content("Sorry " + username);
        //    }
        //}


        //Complex model binding

        [HttpPost]
        public ContentResult Login(User model)
        {
            if (model.Username == "scott" && model.Password == "tiger")
            {
                return Content("Welcome scott");
            }
            else
            {
                return Content("Sorry " + model.Username);
            }
        }
    }
}