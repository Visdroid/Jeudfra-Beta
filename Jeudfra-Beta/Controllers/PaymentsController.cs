using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jeudfra_Beta.Controllers
{
    public class PaymentsController : Controller
    {
        // GET: Payments
        public ActionResult New()
        {
            return View();
        }
    }
}