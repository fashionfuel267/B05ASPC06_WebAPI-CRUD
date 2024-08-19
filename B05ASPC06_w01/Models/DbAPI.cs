using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace B05ASPC06_w01.Models
{
    public class DbAPI:DbContext
    {
        public DbSet<Client> Clients { get; set; }
    }
}