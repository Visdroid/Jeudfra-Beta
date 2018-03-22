using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jeudfra_Beta.Models
{
    public class Child
    {
        public int Id { get; set; }


        [StringLength(255)]
        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        [Display(Name = "ID Number")]
        public string NationalIdNumber { get; set; }


        [Display(Name = "Date Of Birth")]
        public DateTime? BirthDate { get; set; }

        public string Age { get; set; }
        [Required]
        public string Gender { get; set; }
    }
}