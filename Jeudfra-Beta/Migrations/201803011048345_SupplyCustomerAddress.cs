namespace Jeudfra_Beta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SupplyCustomerAddress : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "City", c => c.String());
            AddColumn("dbo.Clients", "Suburb", c => c.String());
            AddColumn("dbo.Clients", "Street", c => c.String());
            AddColumn("dbo.Clients", "HouseNumber", c => c.Int(nullable: false));
            AddColumn("dbo.Clients", "AreaCode", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clients", "AreaCode");
            DropColumn("dbo.Clients", "HouseNumber");
            DropColumn("dbo.Clients", "Street");
            DropColumn("dbo.Clients", "Suburb");
            DropColumn("dbo.Clients", "City");
        }
    }
}
