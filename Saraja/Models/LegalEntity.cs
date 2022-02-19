using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Saraja.Models
{
    public class LegalEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Address { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public double Indoor1 { get; set; }

        public double Indoor2 { get; set; }

    }
}
