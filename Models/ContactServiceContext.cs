﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ContactService.Models
{
    public class ContactServiceContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ContactServiceContext() : base("name=ContactServiceContext")
        {
        }

        public System.Data.Entity.DbSet<ContactService.Models.State> States { get; set; }

        public System.Data.Entity.DbSet<ContactService.Models.City> Cities { get; set; }

        public System.Data.Entity.DbSet<ContactService.Models.Company> Companies { get; set; }

        public System.Data.Entity.DbSet<ContactService.Models.Contact> Contacts { get; set; }
    }
}
