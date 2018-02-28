namespace Jeudfra_Beta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomerAddress : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "City", c => c.String());
            AddColumn("dbo.Clients", "Suburb", c => c.String());
            AddColumn("dbo.Clients", "Street", c => c.String());
            AddColumn("dbo.Clients", "houseNumber", c => c.Int(nullable: false));
            AddColumn("dbo.Clients", "areaCode", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clients", "areaCode");
            DropColumn("dbo.Clients", "houseNumber");
            DropColumn("dbo.Clients", "Street");
            DropColumn("dbo.Clients", "Suburb");
            DropColumn("dbo.Clients", "City");
        }
    }
}
