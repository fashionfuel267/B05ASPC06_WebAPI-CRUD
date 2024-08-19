namespace B05ASPC06_w01.Migrations
{
    using B05ASPC06_w01.Models;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<B05ASPC06_w01.Models.DbAPI>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(B05ASPC06_w01.Models.DbAPI context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            var client = new Client
            {
                 Name="Hanif",
                  Address="Mirpur",
                  Contact="01447785463"
            };
            context.Clients.Add(client);
            context.Clients.AddRange(new List<Client>
            {
                new Client{Name="tamim",Address="Uttara", Contact="01447785236"},
                new Client{Name="Hasiv",Address="Uttara", Contact="01447775236"},
                new Client{Name="Jafar",Address="Uttara", Contact="01447785236"},
            });
            context.SaveChanges();
        }
    }
}
