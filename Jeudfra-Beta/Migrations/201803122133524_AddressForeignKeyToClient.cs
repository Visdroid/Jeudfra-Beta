namespace Jeudfra_Beta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddressForeignKeyToClient : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "AddressId", c => c.Byte(nullable: false));
            AddColumn("dbo.Clients", "Address_Id", c => c.Int());
            CreateIndex("dbo.Clients", "Address_Id");
            AddForeignKey("dbo.Clients", "Address_Id", "dbo.Addresses", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "Address_Id", "dbo.Addresses");
            DropIndex("dbo.Clients", new[] { "Address_Id" });
            DropColumn("dbo.Clients", "Address_Id");
            DropColumn("dbo.Clients", "AddressId");
        }
    }
}
