using Accounting.DataLayer.Entities;
using System.Data.Entity;

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
        public virtual DbSet<Registration> Registrations { get; set; }
        public virtual DbSet<Cheque> Cheques { get; set; }
        public virtual DbSet<SellInvoice> SellInvoices { get; set; }
        public virtual DbSet<ReturnFromSellIncoice> ReturnFromSells { get; set; }
        public virtual DbSet<ReturnFromBuyIncoice> ReturnFromBuyIncoices { get; set; }
        public virtual DbSet<BuyInvoice> BuyInvoices { get; set; }
        public virtual DbSet<Seller> Sellers { get; set; }



        //--------Seed data--------









































        //---------------------------------------

    }


}
