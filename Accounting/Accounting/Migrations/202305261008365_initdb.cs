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
                        id = c.Long(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        CompanyName = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
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
                        id = c.Long(nullable: false, identity: true),
                        Invoice = c.String(),
                        Quantity = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        TotalAmount = c.Int(nullable: false),
                        ProductId_id = c.Long(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Products", t => t.ProductId_id)
                .Index(t => t.ProductId_id);
            
            CreateTable(
                "dbo.Registrations",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
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
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        NameOfUser = c.String(),
                        Role = c.String(),
                        UserName = c.String(),
                        User_Password = c.String(),
                        ContactNo = c.String(),
                        Email = c.String(),
                        JoiningDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        StockDate = c.DateTime(nullable: false),
                        Quantity = c.Int(nullable: false),
                        TotalPrice = c.Int(nullable: false),
                        ProductId_id = c.Long(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Products", t => t.ProductId_id)
                .Index(t => t.ProductId_id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        Role = c.String(),
                        UserName = c.String(maxLength: 50),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stocks", "ProductId_id", "dbo.Products");
            DropForeignKey("dbo.ProductSolds", "ProductId_id", "dbo.Products");
            DropIndex("dbo.Stocks", new[] { "ProductId_id" });
            DropIndex("dbo.ProductSolds", new[] { "ProductId_id" });
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
