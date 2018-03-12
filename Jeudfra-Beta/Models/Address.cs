using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Jeudfra_Beta.Models
{
    public class Address
    {
        public int Id { get; set; }
        [Required]
        public string City { get; set; }
        public string Suburb { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public int AreaCode { get; set; }
    }
}