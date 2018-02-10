namespace Jeudfra_Beta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            //Sql("INSERT INTO MembershipTypes(Id, AgeType, MonthlyPremium) VALUES (1,Adult,60)");
            //Sql("INSERT INTO MembershipTypes(Id, AgeType, MonthlyPremium) VALUES (2,Senior,70)");
            //Sql("INSERT INTO MembershipTypes(Id, AgeType, MonthlyPremium) VALUES (3,Elder,90)");
           
        }
        
        public override void Down()
        {
        }
    }
}
