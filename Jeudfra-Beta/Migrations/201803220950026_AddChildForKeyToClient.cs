namespace Jeudfra_Beta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddChildForKeyToClient : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "ChildId", c => c.Byte(nullable: false));
            AddColumn("dbo.Clients", "Child_Id", c => c.Int());
            CreateIndex("dbo.Clients", "Child_Id");
            AddForeignKey("dbo.Clients", "Child_Id", "dbo.Children", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "Child_Id", "dbo.Children");
            DropIndex("dbo.Clients", new[] { "Child_Id" });
            DropColumn("dbo.Clients", "Child_Id");
            DropColumn("dbo.Clients", "ChildId");
        }
    }
}
