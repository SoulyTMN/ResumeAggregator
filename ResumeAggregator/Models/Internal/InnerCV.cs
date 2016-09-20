using ResumeAggregator.Models.E1;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ResumeAggregator.Models.Internal
{
    public class InnerCV
    {
        public int Id { get; set; }
        //public int OwnerId { get; set; } NOT USED
        public int WantedSalary { get; set; }
        public int WantedSalaryRub { get; set; }
        public int Age { get; set; }
        public string Header { get; set; }
        public string PersonalQualities { get; set; }
        public string Institution { get; set; }
        public string EducationSpecialty { get; set; }
        public string EducationDescription { get; set; }
        public string Experience { get; set; }
        public string Url { get; set; }
        public string Skills { get; set; }
        public string Birthday { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? ModDate { get; set; }
        public string Removal { get; set; }
        public int IsDriver { get; set; }
        public int IsJourney { get; set; }
        public int IsSmoke { get; set; }
        public int HasChild { get; set; }
        public string Sex { get; set; }
        public string MaritalStatus { get; set; }
        public int SurnameHide { get; set; }
        public int CanAcceptReplies { get; set; }
        public int HideBirthday { get; set; }
        //public string visibility_type { get; set; } NOT USED
        public int EducationId { get; set; }
        [ForeignKey("EducationId")]
        public Education education { get; set; }
        public int WorkingtypeId { get; set; }
        [ForeignKey("WorkingtypeId")]
        public WorkingType WorkingType { get; set; }
        public int ScheduleId { get; set; }
        [ForeignKey("ScheduleId")]
        public Schedule schedule { get; set; }
        public int CurrencyId { get; set; }
        [ForeignKey("CurrencyId")]
        public Currency Currency { get; set; }
        public int ExpirienceLengthId { get; set; }
        [ForeignKey("ExpirienceLengthId")]
        public ExperienceLength ExpirienceLength { get; set; }
        public int CitizenshipId { get; set; }
        [ForeignKey("CitizenshipId")]
        public Citizenship Citizenship { get; set; }

        public List<InnerCity> Cities { get; set; }

        public IList<DriverLicense> DriversLicenses { get; set; }

        //public LanguageWithLevel languages { get; set; } NOT USED

        public IList<InnerSecondaryEducations> SecondaryEducations { get; set; }
        public IList<InnerInstitutionCollection> Institutions { get; set; }
        public IList<InnerJob> jobs { get; set; }
        public IList<InnerRubric> rubrics { get; set; }
        public IList<InnerRecommendation> recommendations { get; set; }

        //public int state { get; set; } NOT USED
        //public int validate_state { get; set; } NOT USED
        //public int entity { get; set; } NOT USED
        public int ContactId { get; set; }
        [ForeignKey("ContactId")]
        public Contact Contact { get; set; }
        public string PhotoId { get; set; }
        [ForeignKey("PhotoId")]
        public Photo Photo { get; set; }
        public string Salary { get; set; }
        public string InfoShort { get; set; }
        public string Info { get; set; }
        //public int views { get; set; } NOT USED
        //public string access_status { get; set; } NOT USED
        //public string access_due_date { get; set; } NOT USED
        // public string apiece_count { get; set; } NOT USED
        //public string is_upped { get; set; } NOT USED 
        //public string is_limit_exceeded { get; set; } NOT USED
        //public string is_deleted { get; set; } NOT USED
        //public string is_archived { get; set; } NOT USED
        // public string legacy { get; set; } NOT USED
        //public int priority { get; set; } NOT USED
        //public string attachment { get; set; } NOT USED
        public int WorkTimeTotalYear { get; set; }
        public int WorkTimeTotalMonth { get; set; }
        //public IList<Subway> subways { get; set; } NOT USED
        //public IList<District> districts { get; set; } NOT USED
        //public IList<string> tags { get; set; } NOT USED
        //public string imported_via { get; set; } NOT USED
        public string url_doc { get; set; }
        public string url_pdf { get; set; }
        //public IList<int> contact_geo_ids { get; set; } NOT USED
        //public LastLogin last_log { get; set; } NOT USED
        //public string favorite { get; set; } NOT USED
        //public string hided { get; set; } NOT USED
    }
}