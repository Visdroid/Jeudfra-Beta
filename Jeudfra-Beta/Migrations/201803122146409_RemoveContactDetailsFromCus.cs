namespace Jeudfra_Beta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveContactDetailsFromCus : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Clients", "Cellphone");
            DropColumn("dbo.Clients", "HomeTel");
            DropColumn("dbo.Clients", "WorkTell");
            DropColumn("dbo.Clients", "Email");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clients", "Email", c => c.String());
            AddColumn("dbo.Clients", "WorkTell", c => c.String());
            AddColumn("dbo.Clients", "HomeTel", c => c.String());
            AddColumn("dbo.Clients", "Cellphone", c => c.String());
        }
    }
}
