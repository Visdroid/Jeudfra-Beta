namespace Jeudfra_Beta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovePolicyFromClient : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Clients", "PolicyId", "dbo.Policies");
            DropIndex("dbo.Clients", new[] { "PolicyId" });
            DropColumn("dbo.Clients", "PolicyId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clients", "PolicyId", c => c.Int(nullable: false));
            CreateIndex("dbo.Clients", "PolicyId");
            AddForeignKey("dbo.Clients", "PolicyId", "dbo.Policies", "Id", cascadeDelete: true);
        }
    }
}
