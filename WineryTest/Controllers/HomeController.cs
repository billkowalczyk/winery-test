using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BillWinery.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet, Route(""), Route("Index")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet, Route("Account")]
        public ActionResult Account()
        {
            return View();
        }

        [HttpGet, Route("Cart")]
        public ActionResult Cart()
        {
            return View();
        }

        [HttpGet, Route("Register")]
        public ActionResult Register()
        {
            return View();
        }

    }
}