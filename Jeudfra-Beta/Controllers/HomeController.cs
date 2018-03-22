using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Jeudfra_Beta.Models;
using Jeudfra_Beta.ViewModels;

namespace Jeudfra_Beta.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();

        } 

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

         
        public ActionResult Index()
        {
           // var policies = _context.Policies.ToList();
            var customers = _context.Customers.ToList();
            var underWriters = _context.UnderWriters.ToList();
            // var customers = _context.Customers.Count();

            var viewModel = new CustomerFormViewModel
            {
                Customer = new Client(),
                customersCount = _context.Customers.Count(),
              //  Policies = policies,
                Customers = customers,
                UnderWriters = underWriters,
                //Address =
                policyCount = _context.Policies.Count(),
                paymentCount = _context.Payments.Count()
                
            };

            return View("Index", viewModel);
            // return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}