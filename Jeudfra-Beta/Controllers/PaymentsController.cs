using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Jeudfra_Beta.Models;
using Jeudfra_Beta.ViewModels;

namespace Jeudfra_Beta.Controllers
{
    public class PaymentsController : Controller
    {
        private ApplicationDbContext _context;
        public PaymentsController()
        {
            _context = new ApplicationDbContext();

        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Payments
        public ActionResult Random()
        {
            return View();
        }
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Save(Payment payment)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new CustomerFormViewModel
                {
                    Payment = payment,
                    //Policies = _context.Policies.ToList()
                };

                return RedirectToAction("Random", "Payments", viewModel);
                //var customers = _context.Customers.Include(c => c.MembershipType).ToList();
                // return View("Random", viewModel);
            }

            if (payment.Id == 0)
                _context.Payments.Add(payment);
            else
            {
                var paymentInDb = _context.Payments.Single(c => c.Id == payment.Id);
                paymentInDb.Customer = payment.Customer;
                paymentInDb.Policy = payment.Policy;
                paymentInDb.DatePaid = payment.DatePaid;
                
                // customerInDb.PolicyId = customer.PolicyId;
            }

            _context.SaveChanges();

            return RedirectToAction("Random", "Payments");
            //return View();
        }

        public ActionResult Details(int id)
        {
            var payment = _context.Payments.SingleOrDefault(c => c.Id == id);
            if (payment == null)
                return HttpNotFound();

            var viewModel = new CustomerFormViewModel
            {
                Payment = payment,
                //Policies = _context.Policies.ToList()
            };
            return View(viewModel);
        }
    }
}