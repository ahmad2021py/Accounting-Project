namespace Accounting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixProductEntity : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Category", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Category", c => c.Int(nullable: false));
        }
    }
}
