﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Jeudfra_Beta.Models;
using Jeudfra_Beta.ViewModels;

namespace Jeudfra_Beta.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();

        } 

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        public ActionResult Index()
        {
            var memberShipTypes = _context.MembershipTypes.ToList();
            var viewModel = new CustomerViewModel
            {
                MembershipTypes = memberShipTypes
            };
           
            return View(viewModel);
           // return View();
        }
   
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}