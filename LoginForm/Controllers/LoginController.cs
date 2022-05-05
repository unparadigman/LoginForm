
using LoginForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginForm.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(ModelClient modelClient)
        {
            var cadena = modelClient.Email;
            return RedirectToAction("Index", "Home");
        }
    }
}