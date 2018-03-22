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
        public ViewResult Random()
        {
           //IEnumerable<Client> customers = _context.Customers.Include(c => c.Policy).ToList();
           // return View(customers);
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Save(Client customer)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new CustomerFormViewModel
                {
                    Customer = customer,
                    UnderWriters = _context.UnderWriters.ToList()
                };

                return RedirectToAction("Random", "Client",viewModel);
                //var customers = _context.Customers.Include(c => c.MembershipType).ToList();
               // return View("Random", viewModel);
            }

            if (customer.Id == 0)
                _context.Customers.Add(customer);
            else
            {
                var customerInDb = _context.Customers.Include(c => c.Address).Include(c => c.Spouse).Include(c => c.UnderWriter).Include(c => c.Child).Single(c => c.Id == customer.Id);
                customerInDb.Name = customer.Name;
                customerInDb.Surname = customer.Surname;
                customerInDb.NationalIdNumber = customer.NationalIdNumber;
                customerInDb.BirthDate = customer.BirthDate;
                customerInDb.Gender = customer.Gender;
                // customerInDb.PolicyId = customer.PolicyId;

                customerInDb.Address.City = customer.Address.City;
                customerInDb.Address.Suburb = customer.Address.Suburb;
                customerInDb.Address.Street = customer.Address.Street;
                customerInDb.Address.HouseNumber = customer.Address.HouseNumber;
                customerInDb.Address.AreaCode = customer.Address.AreaCode;

                customerInDb.Spouse.Name = customer.Spouse.Name;
                customerInDb.Spouse.Surname = customer.Spouse.Surname;
                customerInDb.Spouse.NationalIdNumber = customer.Spouse.NationalIdNumber;
                customerInDb.Spouse.BirthDate = customer.Spouse.BirthDate;
                customerInDb.Spouse.Gender = customer.Spouse.Gender;

                customerInDb.Child.Name = customer.Child.Name;
                customerInDb.Child.Surname = customer.Child.Surname;
                customerInDb.Child.NationalIdNumber = customer.Child.NationalIdNumber;
                customerInDb.Child.BirthDate = customer.Child.BirthDate;
                customerInDb.Child.Gender = customer.Child.Gender;

                customerInDb.UnderWriterId = customer.UnderWriterId;
                //customerInDb.Spouse.Surname = customer.Spouse.Surname;
                //customerInDb.Spouse.NationalIdNumber = customer.Spouse.NationalIdNumber;

            }

            _context.SaveChanges();

            return RedirectToAction("Random", "Client");
            //return View();
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers
                .Include(c => c.Address)
                .Include(c => c.Spouse)
                .Include(c => c.Child)
                .Include(c => c.UnderWriter)
                .SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();

            var viewModel = new CustomerFormViewModel
            {
                Customer = customer,
                UnderWriters = _context.UnderWriters.ToList()
            };
            return View(viewModel);
        }

    }
}