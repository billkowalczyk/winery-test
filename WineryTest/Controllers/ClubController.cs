using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BillWinery.Controllers
{
    public class ClubController : Controller
    {
        // GET: Club
        [HttpGet, Route("Club"), Route("Club/Index")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet, Route("ClubSignup")]
        public ActionResult ClubSignup()
        {
            return View();
        }
    }
}