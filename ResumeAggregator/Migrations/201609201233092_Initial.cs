namespace ResumeAggregator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Citizenships",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        firstname = c.String(),
                        patronymic = c.String(),
                        street = c.String(),
                        building = c.String(),
                        room = c.String(),
                        SubwayId = c.Int(nullable: false),
                        DistrictId = c.Int(nullable: false),
                        address_description = c.String(),
                        address = c.String(),
                        CityId = c.Int(nullable: false),
                        icq = c.String(),
                        skype = c.String(),
                        url = c.String(),
                        facebook = c.String(),
                        moi_krug = c.String(),
                        linkedin = c.String(),
                        twitter = c.String(),
                        vk = c.String(),
                        use_messages = c.String(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Cities", t => t.CityId)
                .ForeignKey("dbo.Districts", t => t.DistrictId)
                .ForeignKey("dbo.Subways", t => t.SubwayId)
                .Index(t => t.SubwayId)
                .Index(t => t.DistrictId)
                .Index(t => t.CityId);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        locative = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Districts",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        City_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Cities", t => t.City_id)
                .Index(t => t.City_id);
            
            CreateTable(
                "dbo.Subways",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        City_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Cities", t => t.City_id)
                .Index(t => t.City_id);
            
            CreateTable(
                "dbo.Currencies",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        alias = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.DriverLicenses",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.InnerCVs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WantedSalary = c.Int(nullable: false),
                        WantedSalaryRub = c.Int(nullable: false),
                        Age = c.Int(nullable: false),
                        Header = c.String(),
                        PersonalQualities = c.String(),
                        Institution = c.String(),
                        EducationSpecialty = c.String(),
                        EducationDescription = c.String(),
                        Experience = c.String(),
                        Url = c.String(),
                        Skills = c.String(),
                        Birthday = c.String(),
                        AddDate = c.DateTime(),
                        ModDate = c.DateTime(),
                        Removal = c.String(),
                        IsDriver = c.Int(nullable: false),
                        IsJourney = c.Int(nullable: false),
                        IsSmoke = c.Int(nullable: false),
                        HasChild = c.Int(nullable: false),
                        Sex = c.String(),
                        MaritalStatus = c.String(),
                        SurnameHide = c.Int(nullable: false),
                        CanAcceptReplies = c.Int(nullable: false),
                        HideBirthday = c.Int(nullable: false),
                        EducationId = c.Int(nullable: false),
                        WorkingtypeId = c.Int(nullable: false),
                        ScheduleId = c.Int(nullable: false),
                        CurrencyId = c.Int(nullable: false),
                        ExpirienceLengthId = c.Int(nullable: false),
                        CitizenshipId = c.Int(nullable: false),
                        ContactId = c.Int(nullable: false),
                        PhotoId = c.String(maxLength: 128),
                        Salary = c.String(),
                        InfoShort = c.String(),
                        Info = c.String(),
                        WorkTimeTotalYear = c.Int(nullable: false),
                        WorkTimeTotalMonth = c.Int(nullable: false),
                        UrlDoc = c.String(),
                        UrlPdf = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Citizenships", t => t.CitizenshipId)
                .ForeignKey("dbo.Contacts", t => t.ContactId)
                .ForeignKey("dbo.Currencies", t => t.CurrencyId)
                .ForeignKey("dbo.Educations", t => t.EducationId)
                .ForeignKey("dbo.ExperienceLengths", t => t.ExpirienceLengthId)
                .ForeignKey("dbo.Photos", t => t.PhotoId)
                .ForeignKey("dbo.Schedules", t => t.ScheduleId)
                .ForeignKey("dbo.WorkingTypes", t => t.WorkingtypeId)
                .Index(t => t.EducationId)
                .Index(t => t.WorkingtypeId)
                .Index(t => t.ScheduleId)
                .Index(t => t.CurrencyId)
                .Index(t => t.ExpirienceLengthId)
                .Index(t => t.CitizenshipId)
                .Index(t => t.ContactId)
                .Index(t => t.PhotoId);
            
            CreateTable(
                "dbo.InnerCities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Locative = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Educations",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.ExperienceLengths",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.InnerInstitutionCollections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CityId = c.Int(nullable: false),
                        FormId = c.Int(nullable: false),
                        FacultyId = c.Int(nullable: false),
                        SpecialityId = c.Int(nullable: false),
                        DateFrom = c.String(),
                        DateTo = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId)
                .ForeignKey("dbo.Faculties", t => t.FacultyId)
                .ForeignKey("dbo.Forms", t => t.FormId)
                .ForeignKey("dbo.Specialities", t => t.SpecialityId)
                .Index(t => t.CityId)
                .Index(t => t.FormId)
                .Index(t => t.FacultyId)
                .Index(t => t.SpecialityId);
            
            CreateTable(
                "dbo.Faculties",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Forms",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Specialities",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        count = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.InnerJobs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateFrom = c.String(),
                        DateTo = c.String(),
                        CityId = c.Int(nullable: false),
                        PositionId = c.Int(nullable: false),
                        CompanyId = c.Int(nullable: false),
                        Description = c.String(),
                        IsStillWorking = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId)
                .ForeignKey("dbo.Companies", t => t.CompanyId)
                .ForeignKey("dbo.Positions", t => t.PositionId)
                .Index(t => t.CityId)
                .Index(t => t.PositionId)
                .Index(t => t.CompanyId);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Photos",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        url = c.String(),
                        size = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.InnerRecommendations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CityId = c.Int(nullable: false),
                        CompanyId = c.Int(nullable: false),
                        Phone = c.String(),
                        PhoneComment = c.String(),
                        Fullname = c.String(),
                        PositionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId)
                .ForeignKey("dbo.Companies", t => t.CompanyId)
                .ForeignKey("dbo.Positions", t => t.PositionId)
                .Index(t => t.CityId)
                .Index(t => t.CompanyId)
                .Index(t => t.PositionId);
            
            CreateTable(
                "dbo.InnerRubrics",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.InnerSecondaryEducations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                        CourseName = c.String(),
                        Date = c.String(),
                        CityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId)
                .Index(t => t.CityId);
            
            CreateTable(
                "dbo.WorkingTypes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.InnerCityInnerCVs",
                c => new
                    {
                        InnerCity_Id = c.Int(nullable: false),
                        InnerCV_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.InnerCity_Id, t.InnerCV_Id })
                .ForeignKey("dbo.InnerCities", t => t.InnerCity_Id)
                .ForeignKey("dbo.InnerCVs", t => t.InnerCV_Id)
                .Index(t => t.InnerCity_Id)
                .Index(t => t.InnerCV_Id);
            
            CreateTable(
                "dbo.InnerCVDriverLicenses",
                c => new
                    {
                        InnerCV_Id = c.Int(nullable: false),
                        DriverLicense_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.InnerCV_Id, t.DriverLicense_id })
                .ForeignKey("dbo.InnerCVs", t => t.InnerCV_Id)
                .ForeignKey("dbo.DriverLicenses", t => t.DriverLicense_id)
                .Index(t => t.InnerCV_Id)
                .Index(t => t.DriverLicense_id);
            
            CreateTable(
                "dbo.InnerInstitutionCollectionInnerCVs",
                c => new
                    {
                        InnerInstitutionCollection_Id = c.Int(nullable: false),
                        InnerCV_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.InnerInstitutionCollection_Id, t.InnerCV_Id })
                .ForeignKey("dbo.InnerInstitutionCollections", t => t.InnerInstitutionCollection_Id)
                .ForeignKey("dbo.InnerCVs", t => t.InnerCV_Id)
                .Index(t => t.InnerInstitutionCollection_Id)
                .Index(t => t.InnerCV_Id);
            
            CreateTable(
                "dbo.InnerJobInnerCVs",
                c => new
                    {
                        InnerJob_Id = c.Int(nullable: false),
                        InnerCV_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.InnerJob_Id, t.InnerCV_Id })
                .ForeignKey("dbo.InnerJobs", t => t.InnerJob_Id)
                .ForeignKey("dbo.InnerCVs", t => t.InnerCV_Id)
                .Index(t => t.InnerJob_Id)
                .Index(t => t.InnerCV_Id);
            
            CreateTable(
                "dbo.InnerRecommendationInnerCVs",
                c => new
                    {
                        InnerRecommendation_Id = c.Int(nullable: false),
                        InnerCV_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.InnerRecommendation_Id, t.InnerCV_Id })
                .ForeignKey("dbo.InnerRecommendations", t => t.InnerRecommendation_Id)
                .ForeignKey("dbo.InnerCVs", t => t.InnerCV_Id)
                .Index(t => t.InnerRecommendation_Id)
                .Index(t => t.InnerCV_Id);
            
            CreateTable(
                "dbo.InnerRubricInnerCVs",
                c => new
                    {
                        InnerRubric_id = c.Int(nullable: false),
                        InnerCV_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.InnerRubric_id, t.InnerCV_Id })
                .ForeignKey("dbo.InnerRubrics", t => t.InnerRubric_id)
                .ForeignKey("dbo.InnerCVs", t => t.InnerCV_Id)
                .Index(t => t.InnerRubric_id)
                .Index(t => t.InnerCV_Id);
            
            CreateTable(
                "dbo.InnerSecondaryEducationsInnerCVs",
                c => new
                    {
                        InnerSecondaryEducations_Id = c.Int(nullable: false),
                        InnerCV_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.InnerSecondaryEducations_Id, t.InnerCV_Id })
                .ForeignKey("dbo.InnerSecondaryEducations", t => t.InnerSecondaryEducations_Id)
                .ForeignKey("dbo.InnerCVs", t => t.InnerCV_Id)
                .Index(t => t.InnerSecondaryEducations_Id)
                .Index(t => t.InnerCV_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.InnerCVs", "WorkingtypeId", "dbo.WorkingTypes");
            DropForeignKey("dbo.InnerSecondaryEducationsInnerCVs", "InnerCV_Id", "dbo.InnerCVs");
            DropForeignKey("dbo.InnerSecondaryEducationsInnerCVs", "InnerSecondaryEducations_Id", "dbo.InnerSecondaryEducations");
            DropForeignKey("dbo.InnerSecondaryEducations", "CityId", "dbo.Cities");
            DropForeignKey("dbo.InnerCVs", "ScheduleId", "dbo.Schedules");
            DropForeignKey("dbo.InnerRubricInnerCVs", "InnerCV_Id", "dbo.InnerCVs");
            DropForeignKey("dbo.InnerRubricInnerCVs", "InnerRubric_id", "dbo.InnerRubrics");
            DropForeignKey("dbo.InnerRecommendations", "PositionId", "dbo.Positions");
            DropForeignKey("dbo.InnerRecommendationInnerCVs", "InnerCV_Id", "dbo.InnerCVs");
            DropForeignKey("dbo.InnerRecommendationInnerCVs", "InnerRecommendation_Id", "dbo.InnerRecommendations");
            DropForeignKey("dbo.InnerRecommendations", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.InnerRecommendations", "CityId", "dbo.Cities");
            DropForeignKey("dbo.InnerCVs", "PhotoId", "dbo.Photos");
            DropForeignKey("dbo.InnerJobs", "PositionId", "dbo.Positions");
            DropForeignKey("dbo.InnerJobInnerCVs", "InnerCV_Id", "dbo.InnerCVs");
            DropForeignKey("dbo.InnerJobInnerCVs", "InnerJob_Id", "dbo.InnerJobs");
            DropForeignKey("dbo.InnerJobs", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.InnerJobs", "CityId", "dbo.Cities");
            DropForeignKey("dbo.InnerInstitutionCollections", "SpecialityId", "dbo.Specialities");
            DropForeignKey("dbo.InnerInstitutionCollections", "FormId", "dbo.Forms");
            DropForeignKey("dbo.InnerInstitutionCollections", "FacultyId", "dbo.Faculties");
            DropForeignKey("dbo.InnerInstitutionCollectionInnerCVs", "InnerCV_Id", "dbo.InnerCVs");
            DropForeignKey("dbo.InnerInstitutionCollectionInnerCVs", "InnerInstitutionCollection_Id", "dbo.InnerInstitutionCollections");
            DropForeignKey("dbo.InnerInstitutionCollections", "CityId", "dbo.Cities");
            DropForeignKey("dbo.InnerCVs", "ExpirienceLengthId", "dbo.ExperienceLengths");
            DropForeignKey("dbo.InnerCVs", "EducationId", "dbo.Educations");
            DropForeignKey("dbo.InnerCVDriverLicenses", "DriverLicense_id", "dbo.DriverLicenses");
            DropForeignKey("dbo.InnerCVDriverLicenses", "InnerCV_Id", "dbo.InnerCVs");
            DropForeignKey("dbo.InnerCVs", "CurrencyId", "dbo.Currencies");
            DropForeignKey("dbo.InnerCVs", "ContactId", "dbo.Contacts");
            DropForeignKey("dbo.InnerCVs", "CitizenshipId", "dbo.Citizenships");
            DropForeignKey("dbo.InnerCityInnerCVs", "InnerCV_Id", "dbo.InnerCVs");
            DropForeignKey("dbo.InnerCityInnerCVs", "InnerCity_Id", "dbo.InnerCities");
            DropForeignKey("dbo.Contacts", "SubwayId", "dbo.Subways");
            DropForeignKey("dbo.Contacts", "DistrictId", "dbo.Districts");
            DropForeignKey("dbo.Contacts", "CityId", "dbo.Cities");
            DropForeignKey("dbo.Subways", "City_id", "dbo.Cities");
            DropForeignKey("dbo.Districts", "City_id", "dbo.Cities");
            DropIndex("dbo.InnerSecondaryEducationsInnerCVs", new[] { "InnerCV_Id" });
            DropIndex("dbo.InnerSecondaryEducationsInnerCVs", new[] { "InnerSecondaryEducations_Id" });
            DropIndex("dbo.InnerRubricInnerCVs", new[] { "InnerCV_Id" });
            DropIndex("dbo.InnerRubricInnerCVs", new[] { "InnerRubric_id" });
            DropIndex("dbo.InnerRecommendationInnerCVs", new[] { "InnerCV_Id" });
            DropIndex("dbo.InnerRecommendationInnerCVs", new[] { "InnerRecommendation_Id" });
            DropIndex("dbo.InnerJobInnerCVs", new[] { "InnerCV_Id" });
            DropIndex("dbo.InnerJobInnerCVs", new[] { "InnerJob_Id" });
            DropIndex("dbo.InnerInstitutionCollectionInnerCVs", new[] { "InnerCV_Id" });
            DropIndex("dbo.InnerInstitutionCollectionInnerCVs", new[] { "InnerInstitutionCollection_Id" });
            DropIndex("dbo.InnerCVDriverLicenses", new[] { "DriverLicense_id" });
            DropIndex("dbo.InnerCVDriverLicenses", new[] { "InnerCV_Id" });
            DropIndex("dbo.InnerCityInnerCVs", new[] { "InnerCV_Id" });
            DropIndex("dbo.InnerCityInnerCVs", new[] { "InnerCity_Id" });
            DropIndex("dbo.InnerSecondaryEducations", new[] { "CityId" });
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
            DropIndex("dbo.InnerCVs", new[] { "PhotoId" });
            DropIndex("dbo.InnerCVs", new[] { "ContactId" });
            DropIndex("dbo.InnerCVs", new[] { "CitizenshipId" });
            DropIndex("dbo.InnerCVs", new[] { "ExpirienceLengthId" });
            DropIndex("dbo.InnerCVs", new[] { "CurrencyId" });
            DropIndex("dbo.InnerCVs", new[] { "ScheduleId" });
            DropIndex("dbo.InnerCVs", new[] { "WorkingtypeId" });
            DropIndex("dbo.InnerCVs", new[] { "EducationId" });
            DropIndex("dbo.Subways", new[] { "City_id" });
            DropIndex("dbo.Districts", new[] { "City_id" });
            DropIndex("dbo.Contacts", new[] { "CityId" });
            DropIndex("dbo.Contacts", new[] { "DistrictId" });
            DropIndex("dbo.Contacts", new[] { "SubwayId" });
            DropTable("dbo.InnerSecondaryEducationsInnerCVs");
            DropTable("dbo.InnerRubricInnerCVs");
            DropTable("dbo.InnerRecommendationInnerCVs");
            DropTable("dbo.InnerJobInnerCVs");
            DropTable("dbo.InnerInstitutionCollectionInnerCVs");
            DropTable("dbo.InnerCVDriverLicenses");
            DropTable("dbo.InnerCityInnerCVs");
            DropTable("dbo.WorkingTypes");
            DropTable("dbo.InnerSecondaryEducations");
            DropTable("dbo.Schedules");
            DropTable("dbo.InnerRubrics");
            DropTable("dbo.InnerRecommendations");
            DropTable("dbo.Photos");
            DropTable("dbo.Positions");
            DropTable("dbo.InnerJobs");
            DropTable("dbo.Specialities");
            DropTable("dbo.Forms");
            DropTable("dbo.Faculties");
            DropTable("dbo.InnerInstitutionCollections");
            DropTable("dbo.ExperienceLengths");
            DropTable("dbo.Educations");
            DropTable("dbo.InnerCities");
            DropTable("dbo.InnerCVs");
            DropTable("dbo.DriverLicenses");
            DropTable("dbo.Currencies");
            DropTable("dbo.Subways");
            DropTable("dbo.Districts");
            DropTable("dbo.Cities");
            DropTable("dbo.Contacts");
            DropTable("dbo.Companies");
            DropTable("dbo.Citizenships");
        }
    }
}
