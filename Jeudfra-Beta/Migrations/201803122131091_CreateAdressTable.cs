namespace Jeudfra_Beta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateAdressTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        City = c.String(nullable: false),
                        Suburb = c.String(),
                        Street = c.String(),
                        HouseNumber = c.Int(nullable: false),
                        AreaCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Addresses");
        }
    }
}
