using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jeudfra_Beta.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public short SignUpFee { get; set; }
        public int MonthlyPremium { get; set; }
    }
}