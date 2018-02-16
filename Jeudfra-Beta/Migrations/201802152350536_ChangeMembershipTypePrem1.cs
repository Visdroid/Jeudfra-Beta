namespace Jeudfra_Beta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeMembershipTypePrem1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MembershipTypes", "AgeType", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MembershipTypes", "AgeType", c => c.String(maxLength: 255));
        }
    }
}
