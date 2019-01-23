using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContactService.Models
{
    public class City
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        
        // Foreign key
        public int StateId { get; set; }
        // Navigation property
        public State State { get; set; }


    }
}