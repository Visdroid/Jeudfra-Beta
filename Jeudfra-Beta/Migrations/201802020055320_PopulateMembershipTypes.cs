namespace Jeudfra_Beta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes(Id, SignUpFee, MonthlyPremium) VALUES (1,70,1000)");
            Sql("INSERT INTO MembershipTypes(Id, SignUpFee, MonthlyPremium) VALUES (2,80,2000)");
           
        }
        
        public override void Down()
        {
        }
    }
}
