using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeAggregator.Models.E1
{
    public class Resume
    {
        public int id { get; set; }
        public int? owner_id { get; set; }
        public int? wanted_salary { get; set; }
        public int? wanted_salary_rub { get; set; }
        public int? age { get; set; }
        public string header { get; set; }
        public string personal_qualities { get; set; }
        public string institution { get; set; }
        public string education_specialty { get; set; }
        public string education_description { get; set; }
        public string experience { get; set; }
        public string url { get; set; }
        public string skills { get; set; }
        public string birthday { get; set; }
        public string add_date { get; set; }
        public string mod_date { get; set; }
        public string removal { get; set; }
        public string is_driver { get; set; }
        public string is_journey { get; set; }
        public string is_smoke { get; set; }
        public string has_child { get; set; }
        public string sex { get; set; }
        public string marital_status { get; set; }
        public string surname_hide { get; set; }
        public string can_accept_replies { get; set; }
        public string hide_birthday { get; set; }
        public string visibility_type { get; set; }
        public Education education { get; set; }
        public WorkingType working_type { get; set; }
        public Schedule schedule { get; set; }
        public Currency currency { get; set; }
        public ExperienceLength expirience_length { get; set; }
        public Citizenship citizenship { get; set; }
        public IList<City> cities_references { get; set; }
        public IList<DriverLicense> drivers_licenses { get; set; }
        //public LanguageWithLevel languages { get; set; }
        public IList<SecondaryEducations> secondary_educations { get; set; }
        public IList<InstitutionCollection> institutions { get; set; }
        public IList<Job> jobs { get; set; }
        public IList<Rubric> rubrics { get; set; }
        public IList<Recommendation> recommendations { get; set; }
        public int? state { get; set; }
        public int? validate_state { get; set; }
        public int? entity { get; set; }
        public Contact contact { get; set; }
        public Photo photo { get; set; }
        public string salary { get; set; }
        public string info_short { get; set; }
        public string info { get; set; }
        public int? views { get; set; }
        public string access_status { get; set; }
        public string access_due_date { get; set; }
        public string apiece_count { get; set; }
        public string is_upped { get; set; }
        public string is_limit_exceeded { get; set; }
        public string is_deleted { get; set; }
        public string is_archived { get; set; }
        public string legacy { get; set; }
        public int? priority { get; set; }
        public string attachment { get; set; }
        public WorkTimeTotal work_time_total { get; set; }
        public IList<Subway> subways { get; set; }
        public IList<District> districts { get; set; }
        public IList<string> tags { get; set; }
        public string imported_via { get; set; }
        public string url_doc { get; set; }
        public string url_pdf { get; set; }
        public IList<int> contact_geo_ids { get; set; }
        public LastLogin last_log { get; set; }
        public string favorite { get; set; }
        public string hided { get; set; }
    }
}