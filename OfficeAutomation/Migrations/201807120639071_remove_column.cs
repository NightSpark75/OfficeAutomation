namespace OfficeAutomation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class remove_column : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "phone");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "phone", c => c.String());
        }
    }
}
