using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jeudfra_Beta.Models
{
    public class Payment
    {
        public int Id { get; set; }

        [Required]
        public Client Customer { get; set; }

        [Required]
        public Policy Policy { get; set; }

        public DateTime DatePaid { get; set; }

       // public DateTime? ClaimDate { get; set; }
    }
}