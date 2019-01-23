using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactService.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        // Foreign key
        public int CompanyId { get; set; }
        //Navigation property
        public Company Company { get; set; }
    }
}