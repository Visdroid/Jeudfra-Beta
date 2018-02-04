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
        private ApplicationDbContext _context;
        // GET: Policy/Random
        public PolicyController()
        {
            _context = new ApplicationDbContext();

        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ViewResult Random()
        {
            var policies = _context.Policies.ToList();
            return View(policies);
           
        }
        public ActionResult Details(int id)
        {
            var policy = _context.Policies.SingleOrDefault(c => c.Id == id);
            if (policy == null)
                return HttpNotFound();

            return View(policy);
        }
    }
}