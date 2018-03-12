namespace Jeudfra_Beta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UnderWriterForeignKeyToClient : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "UnderWriterId", c => c.Byte(nullable: false));
            AddColumn("dbo.Clients", "UnderWriter_Id", c => c.Int());
            CreateIndex("dbo.Clients", "UnderWriter_Id");
            AddForeignKey("dbo.Clients", "UnderWriter_Id", "dbo.UnderWriters", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "UnderWriter_Id", "dbo.UnderWriters");
            DropIndex("dbo.Clients", new[] { "UnderWriter_Id" });
            DropColumn("dbo.Clients", "UnderWriter_Id");
            DropColumn("dbo.Clients", "UnderWriterId");
        }
    }
}
