using Jeudfra_Beta.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jeudfra_Beta.Dtos
{
    public class CustomerDto
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
        // [DataType(DataType.Date)]
        [MonthlyPremiumByAgeGroup]
        public DateTime? BirthDate { get; set; }

        public string Age { get; set; }
        public string MaritalStatus { get; set; }

        [Required]
        public string Gender { get; set; }


        public string Cellphone { get; set; }
        public string HomeTel { get; set; }
        public string WorkTell { get; set; }
        public string Email { get; set; }
        // public MembershipType MembershipType { get; set; }

        //[Display(Name = "MemberShip Type")]
        public AddressDto Address { get; set; }
        public SpouseDto Spouse { get; set; }
        public UnderWriterDto UnderWriter { get; set; }
        public ChildDto Child { get; set; }



        //public Policy Policy { get; set; }
        // [Display(Name = "Policy Type")]
        public int PolicyId { get; set; }
        public int AddressId { get; set; }
        public int SpouseId { get; set; }
        public int UnderWriterId { get; set; }
        public int ChildId { get; set; }


        public DateTime? JoinDate { get; set; }

        //[Required]
        //public string City { get; set; }
        //public string Suburb { get; set; }
        //public string Street { get; set; }
        //public int HouseNumber { get; set; }
        //public int AreaCode { get; set; }
    }
}