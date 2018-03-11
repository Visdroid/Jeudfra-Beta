﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Jeudfra_Beta.Models;

namespace Jeudfra_Beta.ViewModels
{
    public class PaymentViewModel
    {
        public IEnumerable<Policy> Policies { get; set; }
        public Client Customer { get; set; }
        public int customersCount { get; set; }
        public int policyCount { get; set; }
        public Payment Payment { get; set; }
        public int paymentCount { get; set; }
    }
}