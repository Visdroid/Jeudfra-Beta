using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Jeudfra_Beta.Models;

namespace Jeudfra_Beta.Controllers
{
    public class PolicyController : Controller
    {
        // GET: Policy/Random
  
        public ViewResult Random()
        {
            var policies = GetPolicies();

            return View(policies);
        }
        public ActionResult Details(int id)
        {
            var policy = GetPolicies().SingleOrDefault(c => c.Id == id);
            if (policy == null)
                return HttpNotFound();

            return View(policy);
        }

        public IEnumerable<Policy> GetPolicies()
        {
            return new List<Policy>
            {
                new Policy
                {
                    Id = 1,
                    Name = "Standard Plan",
                    Amount = 70,
                },
                new Policy
                {
                    Id = 2,
                    Name = "Economic Casket",
                    Amount = 80,
                },
                new Policy
                {
                    Id = 3,
                    Name = "Extra Cash",
                    Amount = 80,
                },
                new Policy
                {
                    Id = 4,
                    Name = "Hamper + 2 Sheep",
                    Amount = 70,
                },
                new Policy
                {
                    Id = 5,
                    Name = "Tombstone",
                    Amount = 70,
                },
                new Policy
                {
                    Id = 6,
                    Name = "Standard Casket",
                    Amount = 90,
                },
                new Policy
                {
                    Id = 7,
                    Name = "Mini Dome",
                    Amount = 140,
                },

            };
        }
    }
}