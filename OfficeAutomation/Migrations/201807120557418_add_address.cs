namespace OfficeAutomation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_address : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Address");
        }
    }
}
