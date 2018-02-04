namespace Jeudfra_Beta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            //Sql("INSERT INTO MembershipTypes(Id, SignUpFee, MonthlyPremium) VALUES (1,18,7000)");
            //Sql("INSERT INTO MembershipTypes(Id, SignUpFee, MonthlyPremium) VALUES (2,66,14000)");
            //Sql("INSERT INTO MembershipTypes(Id, SignUpFee, MonthlyPremium) VALUES (3,75,21000)");
           
        }
        
        public override void Down()
        {
        }
    }
}
