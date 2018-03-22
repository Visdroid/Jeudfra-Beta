using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Jeudfra_Beta.Models;
using Jeudfra_Beta.Dtos;
using System.Data.Entity;
using AutoMapper;

namespace Jeudfra_Beta.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();

        }
        //GET /api/Customers
        public IHttpActionResult GetCustomers()
        {

            var customerDtos = _context.Customers
                .Include(c => c.Address)
                .Include(c => c.Spouse)
                .Include(c => c.UnderWriter)
                .Include(c => c.Child)
                .ToList().Select(Mapper.Map<Client, CustomerDto>);

            return Ok(customerDtos);
        }

        //GET /api/Customers/1
        public IHttpActionResult GetCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return NotFound();
            return Ok(Mapper.Map<Client, CustomerDto>(customer));
        }
         
        //POST /api/Customers
        [HttpPost]
        public IHttpActionResult CreateCustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var customer = Mapper.Map<CustomerDto, Client>(customerDto);
            _context.Customers.Add(customer);
            _context.SaveChanges();

            customerDto.Id = customer.Id;
            return Created(new Uri(Request.RequestUri + "/" + customer.Id),customerDto);
        }

        //PUT /api/Customers/1
        [HttpPut]
        public IHttpActionResult UpdateCustomer(int id,CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var customerinDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if(customerinDb == null)
                return NotFound();

            Mapper.Map(customerDto, customerinDb);
            _context.SaveChanges();
            return Ok();

        }

        //DELETE /api/Customers/1
        [HttpDelete]
        public IHttpActionResult DeleteCustomer(int id)
        {
            var customerinDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerinDb == null)
                return NotFound();

            _context.Customers.Remove(customerinDb);
            _context.SaveChanges();

            return Ok();
        }
    }
}
