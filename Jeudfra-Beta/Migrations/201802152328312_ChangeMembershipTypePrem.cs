namespace Jeudfra_Beta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeMembershipTypePrem : DbMigration
    {
        public override void Up()
        {
            //Sql("INSERT INTO MembershipTypes(Id, AgeType, MonthlyPrem) VALUES (1,Adult,300)");
            //Sql("INSERT INTO MembershipTypes(Id, AgeType, MonthlyPrem) VALUES (2,Senior,700)");
            //Sql("INSERT INTO MembershipTypes(Id, AgeType, MonthlyPrem) VALUES (3,Elder,900)");

        }

        public override void Down()
        {
        }
    }
}
