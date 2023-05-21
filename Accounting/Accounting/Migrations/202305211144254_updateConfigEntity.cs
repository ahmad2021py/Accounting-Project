namespace Accounting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateConfigEntity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Configs", "Picture", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Configs", "Picture");
        }
    }
}
