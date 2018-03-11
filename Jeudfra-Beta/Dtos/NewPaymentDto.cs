using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jeudfra_Beta.Dtos
{
    public class NewPaymentDto
    {
        public int CustomerId { get; set; }
        public List<int> PolicyIds { get; set; }
        public CustomerDto Customer { get; set; }
        public PolicyDto Policy { get; set; }
    }
}