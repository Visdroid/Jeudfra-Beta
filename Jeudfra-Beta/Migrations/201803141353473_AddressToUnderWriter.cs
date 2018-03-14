namespace Jeudfra_Beta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddressToUnderWriter : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UnderWriters", "AddressId", c => c.Byte(nullable: false));
            AddColumn("dbo.UnderWriters", "Address_Id", c => c.Int());
            CreateIndex("dbo.UnderWriters", "Address_Id");
            AddForeignKey("dbo.UnderWriters", "Address_Id", "dbo.Addresses", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UnderWriters", "Address_Id", "dbo.Addresses");
            DropIndex("dbo.UnderWriters", new[] { "Address_Id" });
            DropColumn("dbo.UnderWriters", "Address_Id");
            DropColumn("dbo.UnderWriters", "AddressId");
        }
    }
}
