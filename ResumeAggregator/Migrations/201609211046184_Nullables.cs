namespace ResumeAggregator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Nullables : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Contacts", new[] { "SubwayId" });
            DropIndex("dbo.Contacts", new[] { "DistrictId" });
            DropIndex("dbo.Contacts", new[] { "CityId" });
            DropIndex("dbo.InnerCVs", new[] { "EducationId" });
            DropIndex("dbo.InnerCVs", new[] { "WorkingtypeId" });
            DropIndex("dbo.InnerCVs", new[] { "ScheduleId" });
            DropIndex("dbo.InnerCVs", new[] { "CurrencyId" });
            DropIndex("dbo.InnerCVs", new[] { "ExpirienceLengthId" });
            DropIndex("dbo.InnerCVs", new[] { "CitizenshipId" });
            DropIndex("dbo.InnerCVs", new[] { "ContactId" });
            DropIndex("dbo.InnerInstitutionCollections", new[] { "CityId" });
            DropIndex("dbo.InnerInstitutionCollections", new[] { "FormId" });
            DropIndex("dbo.InnerInstitutionCollections", new[] { "FacultyId" });
            DropIndex("dbo.InnerInstitutionCollections", new[] { "SpecialityId" });
            DropIndex("dbo.InnerJobs", new[] { "CityId" });
            DropIndex("dbo.InnerJobs", new[] { "PositionId" });
            DropIndex("dbo.InnerJobs", new[] { "CompanyId" });
            DropIndex("dbo.InnerRecommendations", new[] { "CityId" });
            DropIndex("dbo.InnerRecommendations", new[] { "CompanyId" });
            DropIndex("dbo.InnerRecommendations", new[] { "PositionId" });
            AlterColumn("dbo.Contacts", "SubwayId", c => c.Int());
            AlterColumn("dbo.Contacts", "DistrictId", c => c.Int());
            AlterColumn("dbo.Contacts", "CityId", c => c.Int());
            AlterColumn("dbo.InnerCVs", "EducationId", c => c.Int());
            AlterColumn("dbo.InnerCVs", "WorkingtypeId", c => c.Int());
            AlterColumn("dbo.InnerCVs", "ScheduleId", c => c.Int());
            AlterColumn("dbo.InnerCVs", "CurrencyId", c => c.Int());
            AlterColumn("dbo.InnerCVs", "ExpirienceLengthId", c => c.Int());
            AlterColumn("dbo.InnerCVs", "CitizenshipId", c => c.Int());
            AlterColumn("dbo.InnerCVs", "ContactId", c => c.Int());
            AlterColumn("dbo.InnerInstitutionCollections", "CityId", c => c.Int());
            AlterColumn("dbo.InnerInstitutionCollections", "FormId", c => c.Int());
            AlterColumn("dbo.InnerInstitutionCollections", "FacultyId", c => c.Int());
            AlterColumn("dbo.InnerInstitutionCollections", "SpecialityId", c => c.Int());
            AlterColumn("dbo.InnerJobs", "CityId", c => c.Int());
            AlterColumn("dbo.InnerJobs", "PositionId", c => c.Int());
            AlterColumn("dbo.InnerJobs", "CompanyId", c => c.Int());
            AlterColumn("dbo.InnerRecommendations", "CityId", c => c.Int());
            AlterColumn("dbo.InnerRecommendations", "CompanyId", c => c.Int());
            AlterColumn("dbo.InnerRecommendations", "PositionId", c => c.Int());
            CreateIndex("dbo.Contacts", "SubwayId");
            CreateIndex("dbo.Contacts", "DistrictId");
            CreateIndex("dbo.Contacts", "CityId");
            CreateIndex("dbo.InnerCVs", "EducationId");
            CreateIndex("dbo.InnerCVs", "WorkingtypeId");
            CreateIndex("dbo.InnerCVs", "ScheduleId");
            CreateIndex("dbo.InnerCVs", "CurrencyId");
            CreateIndex("dbo.InnerCVs", "ExpirienceLengthId");
            CreateIndex("dbo.InnerCVs", "CitizenshipId");
            CreateIndex("dbo.InnerCVs", "ContactId");
            CreateIndex("dbo.InnerInstitutionCollections", "CityId");
            CreateIndex("dbo.InnerInstitutionCollections", "FormId");
            CreateIndex("dbo.InnerInstitutionCollections", "FacultyId");
            CreateIndex("dbo.InnerInstitutionCollections", "SpecialityId");
            CreateIndex("dbo.InnerJobs", "CityId");
            CreateIndex("dbo.InnerJobs", "PositionId");
            CreateIndex("dbo.InnerJobs", "CompanyId");
            CreateIndex("dbo.InnerRecommendations", "CityId");
            CreateIndex("dbo.InnerRecommendations", "CompanyId");
            CreateIndex("dbo.InnerRecommendations", "PositionId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.InnerRecommendations", new[] { "PositionId" });
            DropIndex("dbo.InnerRecommendations", new[] { "CompanyId" });
            DropIndex("dbo.InnerRecommendations", new[] { "CityId" });
            DropIndex("dbo.InnerJobs", new[] { "CompanyId" });
            DropIndex("dbo.InnerJobs", new[] { "PositionId" });
            DropIndex("dbo.InnerJobs", new[] { "CityId" });
            DropIndex("dbo.InnerInstitutionCollections", new[] { "SpecialityId" });
            DropIndex("dbo.InnerInstitutionCollections", new[] { "FacultyId" });
            DropIndex("dbo.InnerInstitutionCollections", new[] { "FormId" });
            DropIndex("dbo.InnerInstitutionCollections", new[] { "CityId" });
            DropIndex("dbo.InnerCVs", new[] { "ContactId" });
            DropIndex("dbo.InnerCVs", new[] { "CitizenshipId" });
            DropIndex("dbo.InnerCVs", new[] { "ExpirienceLengthId" });
            DropIndex("dbo.InnerCVs", new[] { "CurrencyId" });
            DropIndex("dbo.InnerCVs", new[] { "ScheduleId" });
            DropIndex("dbo.InnerCVs", new[] { "WorkingtypeId" });
            DropIndex("dbo.InnerCVs", new[] { "EducationId" });
            DropIndex("dbo.Contacts", new[] { "CityId" });
            DropIndex("dbo.Contacts", new[] { "DistrictId" });
            DropIndex("dbo.Contacts", new[] { "SubwayId" });
            AlterColumn("dbo.InnerRecommendations", "PositionId", c => c.Int(nullable: false));
            AlterColumn("dbo.InnerRecommendations", "CompanyId", c => c.Int(nullable: false));
            AlterColumn("dbo.InnerRecommendations", "CityId", c => c.Int(nullable: false));
            AlterColumn("dbo.InnerJobs", "CompanyId", c => c.Int(nullable: false));
            AlterColumn("dbo.InnerJobs", "PositionId", c => c.Int(nullable: false));
            AlterColumn("dbo.InnerJobs", "CityId", c => c.Int(nullable: false));
            AlterColumn("dbo.InnerInstitutionCollections", "SpecialityId", c => c.Int(nullable: false));
            AlterColumn("dbo.InnerInstitutionCollections", "FacultyId", c => c.Int(nullable: false));
            AlterColumn("dbo.InnerInstitutionCollections", "FormId", c => c.Int(nullable: false));
            AlterColumn("dbo.InnerInstitutionCollections", "CityId", c => c.Int(nullable: false));
            AlterColumn("dbo.InnerCVs", "ContactId", c => c.Int(nullable: false));
            AlterColumn("dbo.InnerCVs", "CitizenshipId", c => c.Int(nullable: false));
            AlterColumn("dbo.InnerCVs", "ExpirienceLengthId", c => c.Int(nullable: false));
            AlterColumn("dbo.InnerCVs", "CurrencyId", c => c.Int(nullable: false));
            AlterColumn("dbo.InnerCVs", "ScheduleId", c => c.Int(nullable: false));
            AlterColumn("dbo.InnerCVs", "WorkingtypeId", c => c.Int(nullable: false));
            AlterColumn("dbo.InnerCVs", "EducationId", c => c.Int(nullable: false));
            AlterColumn("dbo.Contacts", "CityId", c => c.Int(nullable: false));
            AlterColumn("dbo.Contacts", "DistrictId", c => c.Int(nullable: false));
            AlterColumn("dbo.Contacts", "SubwayId", c => c.Int(nullable: false));
            CreateIndex("dbo.InnerRecommendations", "PositionId");
            CreateIndex("dbo.InnerRecommendations", "CompanyId");
            CreateIndex("dbo.InnerRecommendations", "CityId");
            CreateIndex("dbo.InnerJobs", "CompanyId");
            CreateIndex("dbo.InnerJobs", "PositionId");
            CreateIndex("dbo.InnerJobs", "CityId");
            CreateIndex("dbo.InnerInstitutionCollections", "SpecialityId");
            CreateIndex("dbo.InnerInstitutionCollections", "FacultyId");
            CreateIndex("dbo.InnerInstitutionCollections", "FormId");
            CreateIndex("dbo.InnerInstitutionCollections", "CityId");
            CreateIndex("dbo.InnerCVs", "ContactId");
            CreateIndex("dbo.InnerCVs", "CitizenshipId");
            CreateIndex("dbo.InnerCVs", "ExpirienceLengthId");
            CreateIndex("dbo.InnerCVs", "CurrencyId");
            CreateIndex("dbo.InnerCVs", "ScheduleId");
            CreateIndex("dbo.InnerCVs", "WorkingtypeId");
            CreateIndex("dbo.InnerCVs", "EducationId");
            CreateIndex("dbo.Contacts", "CityId");
            CreateIndex("dbo.Contacts", "DistrictId");
            CreateIndex("dbo.Contacts", "SubwayId");
        }
    }
}
