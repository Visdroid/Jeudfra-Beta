using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Jeudfra_Beta.Models;
using Jeudfra_Beta.Dtos;
using AutoMapper;

namespace Jeudfra_Beta.Controllers.Api
{
    public class NewPaymentController : ApiController
    {
        private ApplicationDbContext _context;

        public NewPaymentController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewPayment(NewPaymentDto newPayment)
        {
            var customer = _context.Customers.Single(
            c => c.Id == newPayment.CustomerId);

            //if(customer == null)
            //    return BadRequest("Customer Id is not valid.");
            

            var policies = _context.Policies.Where(
            m => newPayment.PolicyIds.Contains(m.Id)).ToList();

            if(policies.Count != newPayment.PolicyIds.Count)
                return BadRequest("One or more movies are not valid.");

            foreach (var policy in policies)
            {
                //if (movie.NumberAvailable == 0)
                //    return BadRequest("Movie is not available.");

                //movie.NumberAvailable--;

                var payment = new Payment
                {
                    Customer = customer,
                    Policy = policy,
                    DatePaid = DateTime.Now
                };

                _context.Payments.Add(payment);
            }
            _context.SaveChanges();
            return Ok();
        }
    }
}
