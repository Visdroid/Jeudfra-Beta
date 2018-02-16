using System;
using System.Collections.Generic;
using System.Linq;

using System.Web;
using System.Web.Mvc;
using Jeudfra_Beta.Models;
using Jeudfra_Beta.ViewModels;
using System.Data.Entity;
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
        //[HttpGet]
        public ActionResult Random()
        {
            //var membershipTypes = _context.MembershipTypes.ToList();

            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View("Random",customers);
        }

        //public ActionResult Create()
        //{
        //    var membershipTypes = _context.MembershipTypes.ToList();
        //    var viewModel = new CustomerFormViewModel
        //    {
        //        MembershipTypes = membershipTypes
        //    };
        //      return View(viewModel);
        //}

        [HttpPost]
        public ActionResult Create(Client customer)
        {
            if (customer.Id == 0)
               _context.Customers.Add(customer);
            else
            {
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);
                customerInDb.Name = customer.Name;
                customerInDb.Surname = customer.Surname;
                customerInDb.NationalIdNumber = customer.NationalIdNumber;
                customerInDb.BirthDate = customer.BirthDate;
                customerInDb.Gender = customer.Gender;
            }

            _context.SaveChanges();

            return RedirectToAction("Random", "Client");
            //return View();
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

    }
}