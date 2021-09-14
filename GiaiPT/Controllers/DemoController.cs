using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GiaiPT.Models;

namespace PTPMQL.Controllers
{
    public class DemoController : Controller
    {

        // GET: Demo
        public ActionResult bailam()
        {
            return View();
        }
        [HttpPost]
        public ActionResult bailam(string soA, string soB)
        {
            
        }
    }
}