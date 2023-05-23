namespace Accounting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDb : DbMigration
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
                "dbo.Customers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        NationalCode = c.Long(nullable: false),
                        Name = c.String(nullable: false, maxLength: 20),
                        Address = c.String(nullable: false, maxLength: 255),
                        City = c.String(nullable: false, maxLength: 80),
                        State = c.String(nullable: false, maxLength: 80),
                        ZipCode = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        ProductName = c.String(nullable: false),
                        Features = c.String(nullable: false),
                        Price = c.Double(nullable: false),
                        Picture = c.Binary(nullable: false),
                        Category = c.String(nullable: false),
                        Company = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
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
            DropTable("dbo.Companies");
            DropTable("dbo.Categories");
        }
    }
}
