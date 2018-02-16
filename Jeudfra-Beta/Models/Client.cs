using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace Jeudfra_Beta.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string NationalIdNumber { get; set; }

        [Display(Name = "Date Of Birth")]
        public DateTime? BirthDate { get; set; }
        public string Age { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
        public string Cellphone { get; set; }
        public string HomeTel { get; set; }
        public string WorkTell { get; set; }
        public string Email { get; set; }
        public MembershipType MembershipType { get; set; }

        [Display(Name = "MemberShip Types")]
        public byte MembershipTypeId { get; set; }
        public Policy Policy { get; set; }
        public byte PolicyId { get; set; }
    }
}