using Accounting.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Context
{
   public class Accounting_DbContext : DbContext
    {
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Config> Config { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Stock> Stock { get; set; }
        public virtual DbSet<Sales> Sales { get; set; }
        public virtual DbSet<Registration> Registration { get; set; }
        public virtual DbSet<ProductSold> ProductSold { get; set; }
        public virtual DbSet<Product> Product { get; set; }




    }
}
