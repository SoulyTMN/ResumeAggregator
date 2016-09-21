namespace ResumeAggregator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Nullables2 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.InnerSecondaryEducations", new[] { "CityId" });
            AlterColumn("dbo.InnerCVs", "WantedSalary", c => c.Int());
            AlterColumn("dbo.InnerCVs", "WantedSalaryRub", c => c.Int());
            AlterColumn("dbo.InnerCVs", "Age", c => c.Int());
            AlterColumn("dbo.InnerCVs", "IsDriver", c => c.Int());
            AlterColumn("dbo.InnerCVs", "IsJourney", c => c.Int());
            AlterColumn("dbo.InnerCVs", "IsSmoke", c => c.Int());
            AlterColumn("dbo.InnerCVs", "HasChild", c => c.Int());
            AlterColumn("dbo.InnerCVs", "SurnameHide", c => c.Int());
            AlterColumn("dbo.InnerCVs", "CanAcceptReplies", c => c.Int());
            AlterColumn("dbo.InnerCVs", "HideBirthday", c => c.Int());
            AlterColumn("dbo.InnerCVs", "WorkTimeTotalYear", c => c.Int());
            AlterColumn("dbo.InnerCVs", "WorkTimeTotalMonth", c => c.Int());
            AlterColumn("dbo.Specialities", "count", c => c.Int());
            AlterColumn("dbo.InnerSecondaryEducations", "CityId", c => c.Int());
            CreateIndex("dbo.InnerSecondaryEducations", "CityId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.InnerSecondaryEducations", new[] { "CityId" });
            AlterColumn("dbo.InnerSecondaryEducations", "CityId", c => c.Int(nullable: false));
            AlterColumn("dbo.Specialities", "count", c => c.Int(nullable: false));
            AlterColumn("dbo.InnerCVs", "WorkTimeTotalMonth", c => c.Int(nullable: false));
            AlterColumn("dbo.InnerCVs", "WorkTimeTotalYear", c => c.Int(nullable: false));
            AlterColumn("dbo.InnerCVs", "HideBirthday", c => c.Int(nullable: false));
            AlterColumn("dbo.InnerCVs", "CanAcceptReplies", c => c.Int(nullable: false));
            AlterColumn("dbo.InnerCVs", "SurnameHide", c => c.Int(nullable: false));
            AlterColumn("dbo.InnerCVs", "HasChild", c => c.Int(nullable: false));
            AlterColumn("dbo.InnerCVs", "IsSmoke", c => c.Int(nullable: false));
            AlterColumn("dbo.InnerCVs", "IsJourney", c => c.Int(nullable: false));
            AlterColumn("dbo.InnerCVs", "IsDriver", c => c.Int(nullable: false));
            AlterColumn("dbo.InnerCVs", "Age", c => c.Int(nullable: false));
            AlterColumn("dbo.InnerCVs", "WantedSalaryRub", c => c.Int(nullable: false));
            AlterColumn("dbo.InnerCVs", "WantedSalary", c => c.Int(nullable: false));
            CreateIndex("dbo.InnerSecondaryEducations", "CityId");
        }
    }
}
