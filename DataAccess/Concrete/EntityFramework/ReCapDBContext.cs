using Entities.Concrete;
using Entities.Concrete.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class ReCapDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (System.Environment.MachineName == "NT00783")
            {
                optionsBuilder.UseSqlServer(@"server=NT00783;Database=ReCapDB;Trusted_Connection=true");
            }
            else
            {
                optionsBuilder.UseSqlServer(@"server=DESKTOP-KPP5P5P\SQLEXPRESS;Database=ReCapDB;Trusted_Connection=true");
            }
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<User> Users { get; set; }


    }
}
