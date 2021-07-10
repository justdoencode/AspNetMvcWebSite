using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AspNetMvcWebSite.Models.Entities;

namespace AspNetMvcWebSite.DataAccessLayer
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext()
        {
            Database.SetInitializer(new DatabaseInitializer());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<AdminUser> AdminUsers  { get; set; }
    }
}