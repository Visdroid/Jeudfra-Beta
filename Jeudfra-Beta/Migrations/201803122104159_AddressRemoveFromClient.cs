namespace Jeudfra_Beta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddressRemoveFromClient : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Clients", "City");
            DropColumn("dbo.Clients", "Suburb");
            DropColumn("dbo.Clients", "Street");
            DropColumn("dbo.Clients", "HouseNumber");
            DropColumn("dbo.Clients", "AreaCode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clients", "AreaCode", c => c.Int(nullable: false));
            AddColumn("dbo.Clients", "HouseNumber", c => c.Int(nullable: false));
            AddColumn("dbo.Clients", "Street", c => c.String());
            AddColumn("dbo.Clients", "Suburb", c => c.String());
            AddColumn("dbo.Clients", "City", c => c.String());
        }
    }
}
