using Accounting.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Linq;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Context
{
    public class Accounting_DbContext : DbContext

    {

        
        public Accounting_DbContext() : base("name=AccountingConnectionString")
        {


          
          


        }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<Registration> Registrations { get; set; }
        public virtual DbSet<ProductSold> ProductSolds { get; set; }
        public virtual DbSet<Cheque> Cheques { get; set; }
        public virtual DbSet<Invoice> invoice { get; set; }



        //--------Seed data--------









































        //---------------------------------------

    }


}
