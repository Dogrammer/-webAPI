namespace ContactService.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ContactService.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ContactService.Models.ContactServiceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ContactService.Models.ContactServiceContext context)
        {
            context.States.AddOrUpdate(x => x.Id,
                new State() { Id = 1, name = "Hrvatska"},
                new State() { Id = 2, name = "Srbija"},
                new State() { Id = 3, name = "Slovenija"}
                );

            context.Cities.AddOrUpdate(x => x.Id,
                new City() { Id = 1, Name = "Zagreb", StateId = 1},
                new City() { Id = 2, Name = "Beograd", StateId = 2 },
                new City() { Id = 3, Name = "Ljubljana", StateId = 3 }
                );

            context.Companies.AddOrUpdate(x => x.Id,
                new Company() { Id = 1, Name = "TehnoBit", CityId = 1},
                new Company() { Id = 2, Name = "TehnoSrb", CityId = 2 },
                new Company() { Id = 3, Name = "SloTech", CityId = 3 }
                );

            context.Contacts.AddOrUpdate(X => X.Id,
                new Contact() { Id = 1, FullName = "Ivan Periæ", Email = "ivanperic@gmail.com", CompanyId = 1},
                new Contact() { Id = 2, FullName = "Slobodan Matiæ", Email = "slobomatic@gmail.com" ,CompanyId = 2},
                new Contact() { Id = 3, FullName = "Slavoj Ljubljanko", Email = "slavoj@gmail.com" , CompanyId = 3}
                );
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
