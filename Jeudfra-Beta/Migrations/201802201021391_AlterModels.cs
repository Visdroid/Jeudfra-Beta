namespace Jeudfra_Beta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterModels : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Clients", "Policy_Id", "dbo.Policies");
            DropIndex("dbo.Clients", new[] { "Policy_Id" });
            DropColumn("dbo.Clients", "PolicyId");
            RenameColumn(table: "dbo.Clients", name: "Policy_Id", newName: "PolicyId");
            AddColumn("dbo.Clients", "JoinDate", c => c.DateTime());
            AlterColumn("dbo.Clients", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Clients", "Surname", c => c.String(nullable: false));
            AlterColumn("dbo.Clients", "NationalIdNumber", c => c.String(nullable: false));
            AlterColumn("dbo.Clients", "Gender", c => c.String(nullable: false));
            AlterColumn("dbo.Clients", "PolicyId", c => c.Int(nullable: false));
            AlterColumn("dbo.Clients", "PolicyId", c => c.Int(nullable: false));
            AlterColumn("dbo.MembershipTypes", "AgeType", c => c.String());
            CreateIndex("dbo.Clients", "PolicyId");
            AddForeignKey("dbo.Clients", "PolicyId", "dbo.Policies", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "PolicyId", "dbo.Policies");
            DropIndex("dbo.Clients", new[] { "PolicyId" });
            AlterColumn("dbo.MembershipTypes", "AgeType", c => c.String(maxLength: 255));
            AlterColumn("dbo.Clients", "PolicyId", c => c.Int());
            AlterColumn("dbo.Clients", "PolicyId", c => c.Byte(nullable: false));
            AlterColumn("dbo.Clients", "Gender", c => c.String());
            AlterColumn("dbo.Clients", "NationalIdNumber", c => c.String());
            AlterColumn("dbo.Clients", "Surname", c => c.String());
            AlterColumn("dbo.Clients", "Name", c => c.String());
            DropColumn("dbo.Clients", "JoinDate");
            RenameColumn(table: "dbo.Clients", name: "PolicyId", newName: "Policy_Id");
            AddColumn("dbo.Clients", "PolicyId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Clients", "Policy_Id");
            AddForeignKey("dbo.Clients", "Policy_Id", "dbo.Policies", "Id");
        }
    }
}
