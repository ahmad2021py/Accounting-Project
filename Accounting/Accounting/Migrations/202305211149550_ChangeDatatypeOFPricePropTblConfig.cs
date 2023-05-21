namespace Accounting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDatatypeOFPricePropTblConfig : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Configs", "Price", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Configs", "Price", c => c.Single(nullable: false));
        }
    }
}
