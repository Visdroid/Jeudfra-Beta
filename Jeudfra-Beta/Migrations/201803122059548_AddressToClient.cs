namespace Jeudfra_Beta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddressToClient : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "City", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clients", "City", c => c.String(nullable: false));
        }
    }
}
