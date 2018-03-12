using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Jeudfra_Beta.Models
{
    public class ContactDetail
    {
        public int Id { get; set; }
        public string Cellphone { get; set; }
        public string HomeTel { get; set; }
        public string WorkTell { get; set; }
        public string Email { get; set; }
    }
}