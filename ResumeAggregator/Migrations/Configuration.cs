namespace ResumeAggregator.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ResumeAggregator.Models.ResumeAggregatorContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ResumeAggregator.Models.ResumeAggregatorContext context)
        {
            context.Database.ExecuteSqlCommand("TRUNCATE TABLE dbo.InnerCityInnerCVs");
            context.Database.ExecuteSqlCommand("TRUNCATE TABLE dbo.InnerCVDriverLicenses");
            context.Database.ExecuteSqlCommand("TRUNCATE TABLE dbo.InnerInstitutionCollectionInnerCVs");
            context.Database.ExecuteSqlCommand("TRUNCATE TABLE dbo.InnerJobInnerCVs");
            context.Database.ExecuteSqlCommand("TRUNCATE TABLE dbo.InnerRecommendationInnerCVs");
            context.Database.ExecuteSqlCommand("TRUNCATE TABLE dbo.InnerRubricInnerCVs");
            context.Database.ExecuteSqlCommand("TRUNCATE TABLE dbo.InnerSecondaryEducationsInnerCVs");
            context.SaveChanges();


            context.Database.ExecuteSqlCommand("DELETE FROM dbo.InnerCVs");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.InnerCVs',RESEED,1)");
            context.SaveChanges();

            context.Database.ExecuteSqlCommand("DELETE FROM dbo.InnerRecommendations");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.InnerRecommendations',RESEED,1)");
            context.Database.ExecuteSqlCommand("DELETE FROM dbo.InnerSecondaryEducations");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.InnerSecondaryEducations',RESEED,1)");
            context.Database.ExecuteSqlCommand("DELETE FROM dbo.InnerInstitutionCollections");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.InnerInstitutionCollections',RESEED,1)");
            context.Database.ExecuteSqlCommand("DELETE FROM dbo.InnerRubrics");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.InnerRubrics',RESEED,1)");
            context.Database.ExecuteSqlCommand("DELETE FROM dbo.InnerJobs");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.InnerJobs',RESEED,1)");
            context.SaveChanges();

            context.Database.ExecuteSqlCommand("DELETE FROM dbo.Contacts");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.Contacts',RESEED,1)");
            context.SaveChanges();
            
            context.Database.ExecuteSqlCommand("DELETE FROM dbo.Citizenships");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.Citizenships',RESEED,1)");
            context.Database.ExecuteSqlCommand("DELETE FROM dbo.Companies");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.Companies',RESEED,1)");
            context.Database.ExecuteSqlCommand("DELETE FROM dbo.Currencies");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.Currencies',RESEED,1)");
            context.Database.ExecuteSqlCommand("DELETE FROM dbo.Districts");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.Districts',RESEED,1)");
            context.Database.ExecuteSqlCommand("DELETE FROM dbo.DriverLicenses");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.DriverLicenses',RESEED,1)");
            context.Database.ExecuteSqlCommand("DELETE FROM dbo.Educations");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.Educations',RESEED,1)");
            context.Database.ExecuteSqlCommand("DELETE FROM dbo.ExperienceLengths");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.ExperienceLengths',RESEED,1)");
            context.Database.ExecuteSqlCommand("DELETE FROM dbo.Faculties");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.Faculties',RESEED,1)");
            context.Database.ExecuteSqlCommand("DELETE FROM dbo.Forms");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.Forms',RESEED,1)");
            context.Database.ExecuteSqlCommand("DELETE FROM dbo.Photos");
            context.Database.ExecuteSqlCommand("DELETE FROM dbo.Positions");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.Positions',RESEED,1)");
            context.Database.ExecuteSqlCommand("DELETE FROM dbo.Schedules");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.Schedules',RESEED,1)");
            context.Database.ExecuteSqlCommand("DELETE FROM dbo.Specialities");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.Specialities',RESEED,1)");
            context.Database.ExecuteSqlCommand("DELETE FROM dbo.Subways");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.Subways',RESEED,1)");
            context.Database.ExecuteSqlCommand("DELETE FROM dbo.WorkingTypes");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.WorkingTypes',RESEED,1)");

            context.Database.ExecuteSqlCommand("DELETE FROM dbo.InnerCities");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.InnerCities',RESEED,1)");
            context.Database.ExecuteSqlCommand("DELETE FROM dbo.Cities");
            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('dbo.Cities',RESEED,1)");
        }
    }
}
