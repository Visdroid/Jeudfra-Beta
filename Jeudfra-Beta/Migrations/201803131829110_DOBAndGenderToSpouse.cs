namespace Jeudfra_Beta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DOBAndGenderToSpouse : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Spouses", "BirthDate", c => c.DateTime());
            AddColumn("dbo.Spouses", "Gender", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Spouses", "Gender");
            DropColumn("dbo.Spouses", "BirthDate");
        }
    }
}
