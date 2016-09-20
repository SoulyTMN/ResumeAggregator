using ResumeAggregator.Models.Internal;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ResumeAggregator.Models
{
    public class ResumeAggregatorContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ResumeAggregatorContext() : base("name=ResumeAggregatorContext")
        {
        }

        public System.Data.Entity.DbSet<ResumeAggregator.Models.E1.Education> Educations { get; set; }

        public System.Data.Entity.DbSet<ResumeAggregator.Models.E1.WorkingType> WorkingTypes { get; set; }

        public System.Data.Entity.DbSet<ResumeAggregator.Models.E1.Schedule> Schedules { get; set; }

        public System.Data.Entity.DbSet<ResumeAggregator.Models.E1.Currency> Currencies { get; set; }

        public System.Data.Entity.DbSet<ResumeAggregator.Models.E1.ExperienceLength> ExperienceLengths { get; set; }

        public System.Data.Entity.DbSet<ResumeAggregator.Models.E1.Citizenship> Citizenships { get; set; }

        public System.Data.Entity.DbSet<ResumeAggregator.Models.Internal.InnerCity> InnerCities { get; set; }

        public System.Data.Entity.DbSet<ResumeAggregator.Models.E1.DriverLicense> DriverLicenses { get; set; }

        public System.Data.Entity.DbSet<ResumeAggregator.Models.E1.Subway> Subways { get; set; }

        public System.Data.Entity.DbSet<ResumeAggregator.Models.E1.District> Districts { get; set; }

        public System.Data.Entity.DbSet<ResumeAggregator.Models.E1.Contact> Contacts { get; set; }
        
        public System.Data.Entity.DbSet<ResumeAggregator.Models.E1.Photo> Photos { get; set; }

        public System.Data.Entity.DbSet<ResumeAggregator.Models.Internal.InnerSecondaryEducations> InnerSecondaryEducations { get; set; }

        public System.Data.Entity.DbSet<ResumeAggregator.Models.Internal.InnerRubric> InnerRubrics { get; set; }

        public System.Data.Entity.DbSet<ResumeAggregator.Models.E1.Form> Forms { get; set; }

        public System.Data.Entity.DbSet<ResumeAggregator.Models.E1.Faculty> Faculties { get; set; }

        public System.Data.Entity.DbSet<ResumeAggregator.Models.E1.Speciality> Specialities { get; set; }

        public System.Data.Entity.DbSet<ResumeAggregator.Models.Internal.InnerInstitutionCollection> InnerInstitutionCollections { get; set; }

        public System.Data.Entity.DbSet<ResumeAggregator.Models.E1.Position> Positions { get; set; }

        public System.Data.Entity.DbSet<ResumeAggregator.Models.E1.Company> Companies { get; set; }

        public System.Data.Entity.DbSet<ResumeAggregator.Models.Internal.InnerJob> InnerJobs { get; set; }

        public System.Data.Entity.DbSet<ResumeAggregator.Models.Internal.InnerRecommendation> InnerRecommendations { get; set; }

        public System.Data.Entity.DbSet<ResumeAggregator.Models.Internal.InnerCV> InnerCVs { get; set; }
        
    }
}
