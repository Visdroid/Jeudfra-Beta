namespace Jeudfra_Beta.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMemberShipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "AgeType", c => c.String(maxLength: 255));
            DropColumn("dbo.MembershipTypes", "AgeGroup");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "AgeGruop", c => c.Int(nullable: false));
            //DropColumn("dbo.MembershipTypes", "AgeType");
        }
    }
}
