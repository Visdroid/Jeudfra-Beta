using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using Jeudfra_Beta.Models;

namespace Jeudfra_Beta.Controllers
{
     
    public class ClientController : Controller
    {
        private ApplicationDbContext _context;

        public ClientController()
        {
            _context = new ApplicationDbContext();
            
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Client
        public ViewResult Random()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);
        }
        public ActionResult New()
        {
            return View();
        }
        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
            if (customer == null)
               return HttpNotFound();
            
            return View(customer);
        }
    }
}