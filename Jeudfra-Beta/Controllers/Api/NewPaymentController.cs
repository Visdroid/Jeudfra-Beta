using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
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

        // GET /api/NewPayment
        public IHttpActionResult GetPayments()
        {

            //var paymentDtos = _context.Payments.ToList().Select(Mapper.Map<Payment, NewPaymentDto>);

            var paymentDtos = _context.Payments
                .Include(c => c.Customer)
                .Include(c => c.Policy)
                .ToList()
                .Select(Mapper.Map<Payment, NewPaymentDto>);

            return Ok(paymentDtos);
        }


        //GET /api/Customers/1
        public IHttpActionResult GetPayment(int id)
        {
            var payment = _context.Payments.SingleOrDefault(c => c.Id == id);
            if (payment == null)
                return NotFound();
            return Ok(Mapper.Map<Payment, NewPaymentDto>(payment));
        }

        [HttpPost]
        public IHttpActionResult CreateNewPayment(NewPaymentDto newPayment)
        {
            var customer = _context.Customers.Single(
            c => c.Id == newPayment.CustomerId);

            var policies = _context.Policies.Where(
            m => newPayment.PolicyIds.Contains(m.Id)).ToList();

            if(policies.Count != newPayment.PolicyIds.Count)
                return BadRequest("One or more movies are not valid.");

            foreach (var policy in policies)
            {
              
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
        [HttpPut]
        public IHttpActionResult UpdatePayment(int id, NewPaymentDto paymentDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var paymentinDb = _context.Payments.SingleOrDefault(c => c.Id == id);

            if (paymentinDb == null)
                return NotFound();

            Mapper.Map(paymentDto, paymentinDb);
            _context.SaveChanges();
            return Ok();

        }

        //DELETE /api/Customers/1
        [HttpDelete]
        public IHttpActionResult DeletePayment(int id)
        {
            var paymentinDb = _context.Payments.SingleOrDefault(c => c.Id == id);

            if (paymentinDb == null)
                return NotFound();

            _context.Payments.Remove(paymentinDb);
            _context.SaveChanges();

            return Ok();
        }
    }
}
