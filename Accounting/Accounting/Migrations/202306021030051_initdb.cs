namespace Accounting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryCode = c.Int(nullable: false),
                        Row = c.Long(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.CategoryCode);
            
            CreateTable(
                "dbo.Cheques",
                c => new
                    {
                        ChequeCode = c.String(nullable: false, maxLength: 128),
                        Row = c.Int(nullable: false, identity: true),
                        Bank = c.String(),
                        BankBranch = c.String(),
                        ChequeDate = c.DateTime(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.ChequeCode);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        CompanyCode = c.Int(nullable: false),
                        Row = c.Long(nullable: false, identity: true),
                        CompanyName = c.String(),
                    })
                .PrimaryKey(t => t.CompanyCode);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        NationalCode = c.Long(nullable: false),
                        Row = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                        Address = c.String(maxLength: 255),
                        City = c.String(maxLength: 80),
                        State = c.String(maxLength: 80),
                        ZipCode = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        debtor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        creditor = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.NationalCode);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        InvoiceCode = c.String(nullable: false, maxLength: 128),
                        Row = c.Int(nullable: false, identity: true),
                        InvoiceDate = c.DateTime(nullable: false),
                        FKCustomer = c.Long(nullable: false),
                        FKStock = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        TotalAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SellPricePerUnit = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Off = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.InvoiceCode)
                .ForeignKey("dbo.Customers", t => t.FKCustomer, cascadeDelete: true)
                .ForeignKey("dbo.Stocks", t => t.FKStock, cascadeDelete: true)
                .Index(t => t.FKCustomer)
                .Index(t => t.FKStock);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        Row = c.Long(nullable: false, identity: true),
                        StockCode = c.Int(nullable: false),
                        StockDate = c.DateTime(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Description = c.String(),
                        FKProduct = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StockCode)
                .ForeignKey("dbo.Products", t => t.FKProduct, cascadeDelete: true)
                .Index(t => t.FKProduct);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductCode = c.Int(nullable: false),
                        Row = c.Long(nullable: false, identity: true),
                        ProductName = c.String(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Features = c.String(),
                        Picture = c.Binary(),
                        Category = c.String(),
                        Company = c.String(),
                        CountingUnit = c.String(),
                    })
                .PrimaryKey(t => t.ProductCode);
            
            CreateTable(
                "dbo.ProductSolds",
                c => new
                    {
                        ProductSoldTableCode = c.Int(nullable: false, identity: true),
                        FKInvoice = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ProductSoldTableCode)
                .ForeignKey("dbo.Invoices", t => t.FKInvoice, cascadeDelete: true)
                .Index(t => t.FKInvoice);
            
            CreateTable(
                "dbo.Registrations",
                c => new
                    {
                        Row = c.Long(nullable: false, identity: true),
                        RegistrationsCode = c.Int(nullable: false),
                        Role = c.String(),
                        UserName = c.String(),
                        Password = c.String(),
                        Name = c.String(),
                        Family = c.String(),
                        ContactNumber = c.String(),
                        Email = c.String(),
                        JoiningDate = c.DateTime(nullable: false),
                        Avatar = c.Binary(),
                    })
                .PrimaryKey(t => t.RegistrationsCode);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        Row = c.Long(nullable: false, identity: true),
                        SaleCode = c.Int(nullable: false),
                        NameOfUser = c.String(),
                        Role = c.String(),
                        UserName = c.String(),
                        User_Password = c.String(),
                        ContactNo = c.String(),
                        Email = c.String(),
                        JoiningDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SaleCode);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Row = c.Long(nullable: false, identity: true),
                        UserCode = c.Int(nullable: false),
                        Role = c.String(),
                        UserName = c.String(maxLength: 50),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.UserCode);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductSolds", "FKInvoice", "dbo.Invoices");
            DropForeignKey("dbo.Invoices", "FKStock", "dbo.Stocks");
            DropForeignKey("dbo.Stocks", "FKProduct", "dbo.Products");
            DropForeignKey("dbo.Invoices", "FKCustomer", "dbo.Customers");
            DropIndex("dbo.ProductSolds", new[] { "FKInvoice" });
            DropIndex("dbo.Stocks", new[] { "FKProduct" });
            DropIndex("dbo.Invoices", new[] { "FKStock" });
            DropIndex("dbo.Invoices", new[] { "FKCustomer" });
            DropTable("dbo.Users");
            DropTable("dbo.Sales");
            DropTable("dbo.Registrations");
            DropTable("dbo.ProductSolds");
            DropTable("dbo.Products");
            DropTable("dbo.Stocks");
            DropTable("dbo.Invoices");
            DropTable("dbo.Customers");
            DropTable("dbo.Companies");
            DropTable("dbo.Cheques");
            DropTable("dbo.Categories");
        }
    }
}
