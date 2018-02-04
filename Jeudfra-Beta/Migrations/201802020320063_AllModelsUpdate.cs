namespace Jeudfra_Beta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllModelsUpdate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Policies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Clients", "PolicyId", c => c.Byte(nullable: false));
            AddColumn("dbo.Clients", "Policy_Id", c => c.Int());
            AddColumn("dbo.MembershipTypes", "AgeGruop", c => c.Int(nullable: false));
            CreateIndex("dbo.Clients", "Policy_Id");
            AddForeignKey("dbo.Clients", "Policy_Id", "dbo.Policies", "Id");
            DropColumn("dbo.MembershipTypes", "SignUpFee");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "SignUpFee", c => c.Short(nullable: false));
            DropForeignKey("dbo.Clients", "Policy_Id", "dbo.Policies");
            DropIndex("dbo.Clients", new[] { "Policy_Id" });
            DropColumn("dbo.MembershipTypes", "AgeGruop");
            DropColumn("dbo.Clients", "Policy_Id");
            DropColumn("dbo.Clients", "PolicyId");
            DropTable("dbo.Policies");
        }
    }
}
