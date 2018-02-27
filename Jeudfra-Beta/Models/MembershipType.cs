using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jeudfra_Beta.Models
{
    public class MembershipType
    {
        public int Id { get; set; }     
        public String AgeType { get; set; }
        public int MonthlyPrem{ get; set; }

    }
}