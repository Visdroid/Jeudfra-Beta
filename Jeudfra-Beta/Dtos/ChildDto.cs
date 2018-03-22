using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jeudfra_Beta.Dtos
{
    public class ChildDto
    {
        public int Id { get; set; }


       
        public string Name { get; set; }

     
        public string Surname { get; set; }

       
        public string NationalIdNumber { get; set; }


     
        public DateTime? BirthDate { get; set; }

        public string Age { get; set; }
     
        public string Gender { get; set; }
    }
}