using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Jeudfra_Beta.Models;
using Jeudfra_Beta.Dtos;
using AutoMapper;

namespace Jeudfra_Beta.Controllers.Api
{
    public class PoliciesController : ApiController
    {
        private ApplicationDbContext _context;

        public PoliciesController()
        {
            _context = new ApplicationDbContext();

        }
        //GET /api/Policies
        public IEnumerable<PolicyDto> GetPolicies()
        {
            return _context.Policies.ToList().Select(Mapper.Map<Policy, PolicyDto>);
        }

        //GET /api/Policies/1
        public IHttpActionResult GetPolicy(int id)
        {
            var policy = _context.Policies.SingleOrDefault(c => c.Id == id);
            if (policy == null)
                return NotFound();
            return Ok(Mapper.Map<Policy, PolicyDto>(policy));
        }

        //POST /api/Policies
        [HttpPost]
        public IHttpActionResult CreatePolicy(PolicyDto customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var policy = Mapper.Map<PolicyDto, Policy>(customerDto);
            _context.Policies.Add(policy);
            _context.SaveChanges();

            customerDto.Id = policy.Id;
            return Created(new Uri(Request.RequestUri + "/" + policy.Id), customerDto);
        }

        //PUT /api/Policies/1
        [HttpPut]
        public IHttpActionResult UpdateCustomer(int id, PolicyDto policyDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var policyinDb = _context.Policies.SingleOrDefault(c => c.Id == id);

            if (policyinDb == null)
                return NotFound();

            Mapper.Map(policyDto, policyinDb);
            
     

            _context.SaveChanges();
            return Ok();
        }

        //DELETE /api/Policies/1
        [HttpDelete]
        public IHttpActionResult DeleteCustomer(int id)
        {
            var policyinDb = _context.Policies.SingleOrDefault(c => c.Id == id);

            if (policyinDb == null)
                return NotFound();

            _context.Policies.Remove(policyinDb);
            _context.SaveChanges();

            return Ok();
        }
    }
}