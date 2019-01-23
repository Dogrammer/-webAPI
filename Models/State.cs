using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContactService.Models
{
    public class State
    {
        public int Id { get; set; }
        [Required]
        public string name { get; set; }
    }
}