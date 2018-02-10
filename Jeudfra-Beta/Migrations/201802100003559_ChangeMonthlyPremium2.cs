namespace Jeudfra_Beta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeMonthlyPremium2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Clients", "MembershipTypeId", "dbo.MembershipTypes");
            DropIndex("dbo.Clients", new[] { "MembershipTypeId" });
            DropPrimaryKey("dbo.MembershipTypes");
            AddColumn("dbo.Clients", "MembershipType_Id", c => c.Int());
            AlterColumn("dbo.MembershipTypes", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.MembershipTypes", "Id");
            CreateIndex("dbo.Clients", "MembershipType_Id");
            AddForeignKey("dbo.Clients", "MembershipType_Id", "dbo.MembershipTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "MembershipType_Id", "dbo.MembershipTypes");
            DropIndex("dbo.Clients", new[] { "MembershipType_Id" });
            DropPrimaryKey("dbo.MembershipTypes");
            AlterColumn("dbo.MembershipTypes", "Id", c => c.Byte(nullable: false));
            DropColumn("dbo.Clients", "MembershipType_Id");
            AddPrimaryKey("dbo.MembershipTypes", "Id");
            CreateIndex("dbo.Clients", "MembershipTypeId");
            AddForeignKey("dbo.Clients", "MembershipTypeId", "dbo.MembershipTypes", "Id", cascadeDelete: true);
        }
    }
}
