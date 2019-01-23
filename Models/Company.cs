using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContactService.Models
{
    public class Company
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        
        // Foreign key
        public int CityId { get; set; }
        // Navigation property
        public City City { get; set; }
        
    }
}