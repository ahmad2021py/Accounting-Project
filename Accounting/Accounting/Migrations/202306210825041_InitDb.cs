namespace Accounting.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InitDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BuyInvoices",
                c => new
                {
                    BuyInvoiceCode = c.String(nullable: false, maxLength: 128),
                    Row = c.Int(nullable: false, identity: true),
                    BuyInvoiceDate = c.DateTime(nullable: false),
                    BuyCount = c.Int(nullable: false),
                    BuyPricePerUnit = c.Decimal(nullable: false, precision: 18, scale: 2),
                    Off = c.Int(nullable: false),
                    TotalBuyAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    FKSeller = c.Long(nullable: false),
                    FKStock = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.BuyInvoiceCode)
                .ForeignKey("dbo.Sellers", t => t.FKSeller, cascadeDelete: true)
                .ForeignKey("dbo.Stocks", t => t.FKStock, cascadeDelete: true)
                .Index(t => t.FKSeller)
                .Index(t => t.FKStock);

            CreateTable(
                "dbo.Sellers",
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
                "dbo.Stocks",
                c => new
                {
                    Row = c.Long(nullable: false, identity: true),
                    StockCode = c.Int(nullable: false),
                    StockDate = c.DateTime(nullable: false),
                    Quantity = c.Int(nullable: false),
                    Description = c.String(),
                    BuyPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
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
                    Features = c.String(),
                    Picture = c.Binary(),
                    Category = c.String(),
                    Company = c.String(),
                })
                .PrimaryKey(t => t.ProductCode);

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
                "dbo.ProductSolds",
                c => new
                {
                    ProductSoldTableCode = c.Int(nullable: false, identity: true),
                    FKSellInvoice = c.String(nullable: false, maxLength: 128),
                })
                .PrimaryKey(t => t.ProductSoldTableCode)
                .ForeignKey("dbo.SellInvoices", t => t.FKSellInvoice, cascadeDelete: true)
                .Index(t => t.FKSellInvoice);

            CreateTable(
                "dbo.SellInvoices",
                c => new
                {
                    SellInvoiceCode = c.String(nullable: false, maxLength: 128),
                    Row = c.Int(nullable: false, identity: true),
                    SellInvoiceDate = c.DateTime(nullable: false),
                    FKCustomer = c.Long(nullable: false),
                    FKStock = c.Int(nullable: false),
                    Quantity = c.Int(nullable: false),
                    TotalSellAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    SellPricePerUnit = c.Decimal(nullable: false, precision: 18, scale: 2),
                    Off = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.SellInvoiceCode)
                .ForeignKey("dbo.Customers", t => t.FKCustomer, cascadeDelete: true)
                .ForeignKey("dbo.Stocks", t => t.FKStock, cascadeDelete: true)
                .Index(t => t.FKCustomer)
                .Index(t => t.FKStock);

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
                "dbo.ReturnFromBuyIncoices",
                c => new
                {
                    ReturnFromBuyInvoiceCode = c.Int(nullable: false),
                    Row = c.Int(nullable: false, identity: true),
                    ReturnFromBuyInvoiceDate = c.DateTime(nullable: false),
                    ReturnQuantity = c.Int(nullable: false),
                    FKBuyInvoice = c.String(nullable: false, maxLength: 128),
                })
                .PrimaryKey(t => t.ReturnFromBuyInvoiceCode)
                .ForeignKey("dbo.BuyInvoices", t => t.FKBuyInvoice, cascadeDelete: true)
                .Index(t => t.FKBuyInvoice);

            CreateTable(
                "dbo.ReturnFromSellIncoices",
                c => new
                {
                    ReturnFromSellIncoiceCode = c.String(nullable: false, maxLength: 128),
                    Row = c.Int(nullable: false, identity: true),
                    ReturnFromSellIncoiceDate = c.DateTime(nullable: false),
                    FKCustomer = c.Long(nullable: false),
                    FKStock = c.Int(nullable: false),
                    FKProductSold = c.Int(),
                    ReturnQuantity = c.Int(nullable: false),
                    TotalAmountFromReturnFromSellIncoice = c.Decimal(nullable: false, precision: 18, scale: 2),
                })
                .PrimaryKey(t => t.ReturnFromSellIncoiceCode)
                .ForeignKey("dbo.Customers", t => t.FKCustomer, cascadeDelete: true)
                .ForeignKey("dbo.ProductSolds", t => t.FKProductSold)
                .ForeignKey("dbo.Stocks", t => t.FKStock, cascadeDelete: true)
                .Index(t => t.FKCustomer)
                .Index(t => t.FKStock)
                .Index(t => t.FKProductSold);

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
            DropForeignKey("dbo.ReturnFromSellIncoices", "FKStock", "dbo.Stocks");
            DropForeignKey("dbo.ReturnFromSellIncoices", "FKProductSold", "dbo.ProductSolds");
            DropForeignKey("dbo.ReturnFromSellIncoices", "FKCustomer", "dbo.Customers");
            DropForeignKey("dbo.ReturnFromBuyIncoices", "FKBuyInvoice", "dbo.BuyInvoices");
            DropForeignKey("dbo.ProductSolds", "FKSellInvoice", "dbo.SellInvoices");
            DropForeignKey("dbo.SellInvoices", "FKStock", "dbo.Stocks");
            DropForeignKey("dbo.SellInvoices", "FKCustomer", "dbo.Customers");
            DropForeignKey("dbo.BuyInvoices", "FKStock", "dbo.Stocks");
            DropForeignKey("dbo.Stocks", "FKProduct", "dbo.Products");
            DropForeignKey("dbo.BuyInvoices", "FKSeller", "dbo.Sellers");
            DropIndex("dbo.ReturnFromSellIncoices", new[] { "FKProductSold" });
            DropIndex("dbo.ReturnFromSellIncoices", new[] { "FKStock" });
            DropIndex("dbo.ReturnFromSellIncoices", new[] { "FKCustomer" });
            DropIndex("dbo.ReturnFromBuyIncoices", new[] { "FKBuyInvoice" });
            DropIndex("dbo.SellInvoices", new[] { "FKStock" });
            DropIndex("dbo.SellInvoices", new[] { "FKCustomer" });
            DropIndex("dbo.ProductSolds", new[] { "FKSellInvoice" });
            DropIndex("dbo.Stocks", new[] { "FKProduct" });
            DropIndex("dbo.BuyInvoices", new[] { "FKStock" });
            DropIndex("dbo.BuyInvoices", new[] { "FKSeller" });
            DropTable("dbo.Users");
            DropTable("dbo.Sales");
            DropTable("dbo.ReturnFromSellIncoices");
            DropTable("dbo.ReturnFromBuyIncoices");
            DropTable("dbo.Registrations");
            DropTable("dbo.SellInvoices");
            DropTable("dbo.ProductSolds");
            DropTable("dbo.Customers");
            DropTable("dbo.Companies");
            DropTable("dbo.Cheques");
            DropTable("dbo.Categories");
            DropTable("dbo.Products");
            DropTable("dbo.Stocks");
            DropTable("dbo.Sellers");
            DropTable("dbo.BuyInvoices");
        }
    }
}
