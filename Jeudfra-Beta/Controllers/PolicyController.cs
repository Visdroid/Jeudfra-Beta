using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Jeudfra_Beta.Models;

namespace Jeudfra_Beta.Controllers
{
    public class PolicyController : Controller
    {
        // GET: Policy
        public ActionResult Random()
        {
            var policy = new Policy() {Name = "Standard"};

            return View(policy);
        }
    }
}