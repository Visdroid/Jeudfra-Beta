namespace Jeudfra_Beta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SpouseAndContactDetailForeinKeyToClient : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "SpouseId", c => c.Byte(nullable: false));
            AddColumn("dbo.Clients", "ContactDetailId", c => c.Byte(nullable: false));
            AddColumn("dbo.Clients", "ContactDetail_Id", c => c.Int());
            AddColumn("dbo.Clients", "Spouse_Id", c => c.Int());
            CreateIndex("dbo.Clients", "ContactDetail_Id");
            CreateIndex("dbo.Clients", "Spouse_Id");
            AddForeignKey("dbo.Clients", "ContactDetail_Id", "dbo.ContactDetails", "Id");
            AddForeignKey("dbo.Clients", "Spouse_Id", "dbo.Spouses", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "Spouse_Id", "dbo.Spouses");
            DropForeignKey("dbo.Clients", "ContactDetail_Id", "dbo.ContactDetails");
            DropIndex("dbo.Clients", new[] { "Spouse_Id" });
            DropIndex("dbo.Clients", new[] { "ContactDetail_Id" });
            DropColumn("dbo.Clients", "Spouse_Id");
            DropColumn("dbo.Clients", "ContactDetail_Id");
            DropColumn("dbo.Clients", "ContactDetailId");
            DropColumn("dbo.Clients", "SpouseId");
        }
    }
}
