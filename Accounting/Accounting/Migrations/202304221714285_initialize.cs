namespace Accounting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialize : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        CompanyId = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                    })
                .PrimaryKey(t => t.CompanyId);
            
            CreateTable(
                "dbo.Configs",
                c => new
                    {
                        ConfigId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        Features = c.String(),
                        Price = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.ConfigId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Long(nullable: false, identity: true),
                        Address = c.String(),
                        City = c.String(),
                        State = c.String(),
                        ZipCode = c.Int(nullable: false),
                        Phone = c.Int(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        Category = c.Int(nullable: false),
                        Company = c.String(),
                    })
                .PrimaryKey(t => t.ProductId);
            
            CreateTable(
                "dbo.ProductSolds",
                c => new
                    {
                        ProductId = c.Long(nullable: false, identity: true),
                        Invoice = c.String(),
                        ConfigId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        TotalAmount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId);
            
            CreateTable(
                "dbo.Registrations",
                c => new
                    {
                        RegistrationId = c.Int(nullable: false, identity: true),
                        NameOfUser = c.String(),
                        Role = c.String(),
                        UserName = c.String(),
                        User_Password = c.String(),
                        ContactNo = c.String(),
                        Email = c.String(),
                        JoiningDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.RegistrationId);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        SalesId = c.Int(nullable: false, identity: true),
                        NameOfUser = c.String(),
                        Role = c.String(),
                        UserName = c.String(),
                        User_Password = c.String(),
                        ContactNo = c.String(),
                        Email = c.String(),
                        JoiningDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SalesId);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        StockId = c.Long(nullable: false, identity: true),
                        ConfigId = c.Int(nullable: false),
                        StockDate = c.DateTime(nullable: false),
                        Quantity = c.Int(nullable: false),
                        TotalPrice = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StockId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Role = c.String(),
                        UserName = c.String(),
                        User_Password = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Stocks");
            DropTable("dbo.Sales");
            DropTable("dbo.Registrations");
            DropTable("dbo.ProductSolds");
            DropTable("dbo.Products");
            DropTable("dbo.Customers");
            DropTable("dbo.Configs");
            DropTable("dbo.Companies");
            DropTable("dbo.Categories");
        }
    }
}
