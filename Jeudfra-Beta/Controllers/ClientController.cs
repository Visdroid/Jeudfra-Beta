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

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
               return HttpNotFound();
            
            return View(customer);
        }
        //public IEnumerable<Client> GetCustomers()
        //{
        //    return new List<Client>
        //    {
        //        new Client
        //        {
        //            Id = 1,
        //            Name = "John",
        //            Surname = "Doe",
        //            NationalIdNumber = "9111135184089",
        //            Age = "27",
        //            MaritalStatus = "Married",
        //            Gender = "Male",
        //            Cellphone = "0785743931",
        //            HomeTel = "0548754221",
        //            WorkTell = "0543256985",
        //            Email = "johndoe@gmail.com"
        //        },
        //        new Client
        //        {
        //            Id = 2,
        //            Name = "Jane",
        //            Surname = "Doe",
        //            NationalIdNumber = "9111134184089",
        //            Age = "27",
        //            MaritalStatus = "Married",
        //            Gender = "Female",
        //            Cellphone = "0785743932",
        //            HomeTel = "0548754222",
        //            WorkTell = "0543256986",
        //            Email = "janedoe@gmail.com"
        //        }
        //    };
        //}
    }
}