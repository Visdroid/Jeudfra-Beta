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
            var memberShipTypes = _context.MembershipTypes.ToList();
            var viewModel = new CustomerFormViewModel
            {
                MembershipTypes = memberShipTypes
            };

            return View("Index", viewModel);
            // return View();
        }

        [HttpPost]
        public ActionResult Create(Client customer)
        {
            //if (customer.Id == 0)
            _context.Customers.Add(customer);
            //else
            //{
            //    var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);
            //    customerInDb.Name = customer.Name;
            //    customerInDb.Surname = customer.Surname;
            //    customerInDb.NationalIdNumber = customer.NationalIdNumber;
            //    customerInDb.BirthDate = customer.BirthDate;
            //    customerInDb.Gender = customer.Gender;
            //}

            _context.SaveChanges();
            //return View();
            return RedirectToAction("Random", "Client");

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