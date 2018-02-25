using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Jeudfra_Beta.Models;

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
        public IEnumerable<Client> GetCustomers()
        {
            return _context.Customers.ToList();
        }

        //GET /api/Customers/1
        public Client GetCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if(customer == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return customer;
        }

        //POST /api/Customers
        [HttpPost]
        public Client CreateCustomer(Client customner)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            _context.Customers.Add(customner);
            _context.SaveChanges();

            return customner;
        }

        //PUT /api/Customers/1
        [HttpPut]
        public void UpdateCustomer(int id,Client customner)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            var customerinDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if(customerinDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            customerinDb.Name = customner.Name;
            customerinDb.Surname = customner.Surname;
            customerinDb.NationalIdNumber = customner.NationalIdNumber;
            customerinDb.BirthDate = customner.BirthDate;
            customerinDb.Gender = customner.Gender;
            //customerinDb.Cellphone = customner.Cellphone;
            //customerinDb.HomeTel = customner.HomeTel;
            //customerinDb.WorkTell = customner.WorkTell;
            //customerinDb.Email = customner.Email;
            //customerinDb.Name = customner.Name;
            //customerinDb.Name = customner.Name;

            _context.SaveChanges();
        }

        //DELETE /api/Customers/1
        [HttpDelete]
        public void DeleteCustomer(int id)
        {
            var customerinDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerinDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Customers.Remove(customerinDb);
            _context.SaveChanges();
        }
    }
}
