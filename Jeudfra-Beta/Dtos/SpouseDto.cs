using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jeudfra_Beta.Dtos
{
    public class SpouseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string NationalIdNumber { get; set; }
        public string BirthDate { get; set; }
        public string Gender { get; set; }
    }
}