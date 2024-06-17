using ElectricCalculator22222.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricCalculator.Data
{
    public class ElectricDBContext : DbContext
    {

        // entities
        public DbSet<Customer> Customer { get; set; }
        public DbSet<CustomerIndies> CustomerIndicess { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<CustomerInfo> CustomerInfos { get; set; }
        public DbSet<ElectricPrice> ElectricPrices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            string sqlconnectStr = "Data Source=192.168.0.178,1433;Initial Catalog=ElectricCalculator;User ID=SA;Password=Dai@2018";
            optionsBuilder.UseSqlServer(sqlconnectStr);
        

        }
}
}
