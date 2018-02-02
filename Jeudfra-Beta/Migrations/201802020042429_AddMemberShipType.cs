namespace Jeudfra_Beta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMemberShipType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        SignUpFee = c.Short(nullable: false),
                        MonthlyPremium = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Clients", "MembershipTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Clients", "MembershipTypeId");
            AddForeignKey("dbo.Clients", "MembershipTypeId", "dbo.MembershipTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "MembershipTypeId", "dbo.MembershipTypes");
            DropIndex("dbo.Clients", new[] { "MembershipTypeId" });
            DropColumn("dbo.Clients", "MembershipTypeId");
            DropTable("dbo.MembershipTypes");
        }
    }
}
