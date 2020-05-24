using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TravelShuttle.Core;
using TravelShuttle.Core.Entities;
using TravelShuttle.DataAccess.Abstract;
using TravelShuttle.Entities.Concrete;

namespace TravelShuttle.DataAccess.Concrete.EntityFramework
{
    public class TravelContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=TravelDb; Trusted_Connection=true");
            optionsBuilder.UseSqlServer(@"Server=narinvipturizm.com\MSSQLSERVER2019; Database=narinvip_traveldb; User Id=narinvip_travel; Password=D.a5292100;");
        }


        public DbSet<Car> Cars { get; set; }
        public DbSet<Definition> Definitions { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Image> Images { get; set; }

    }
}
