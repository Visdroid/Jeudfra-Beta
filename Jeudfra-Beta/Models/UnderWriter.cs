using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Jeudfra_Beta.Models
{
    public class UnderWriter
    {
        public int Id { get; set; }
        [StringLength(255)]
        [Required]
        public string Name { get; set; }
        public Address Address { get; set; }
        public byte AddressId { get; set; }
    }
}