namespace Jeudfra_Beta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Clients", "Child_Id", "dbo.Children");
            DropIndex("dbo.Clients", new[] { "Child_Id" });
            DropColumn("dbo.Clients", "ChildId");
            DropColumn("dbo.Clients", "Child_Id");
            DropTable("dbo.Children");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Children",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Surname = c.String(nullable: false),
                        NationalIdNumber = c.String(nullable: false),
                        BirthDate = c.DateTime(),
                        Age = c.String(),
                        Gender = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Clients", "Child_Id", c => c.Int());
            AddColumn("dbo.Clients", "ChildId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Clients", "Child_Id");
            AddForeignKey("dbo.Clients", "Child_Id", "dbo.Children", "Id");
        }
    }
}
