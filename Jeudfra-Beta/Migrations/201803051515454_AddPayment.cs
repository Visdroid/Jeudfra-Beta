namespace Jeudfra_Beta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPayment : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DatePaid = c.DateTime(nullable: false),
                        Customer_Id = c.Int(nullable: false),
                        Policy_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.Customer_Id, cascadeDelete: true)
                .ForeignKey("dbo.Policies", t => t.Policy_Id, cascadeDelete: true)
                .Index(t => t.Customer_Id)
                .Index(t => t.Policy_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payments", "Policy_Id", "dbo.Policies");
            DropForeignKey("dbo.Payments", "Customer_Id", "dbo.Clients");
            DropIndex("dbo.Payments", new[] { "Policy_Id" });
            DropIndex("dbo.Payments", new[] { "Customer_Id" });
            DropTable("dbo.Payments");
        }
    }
}
