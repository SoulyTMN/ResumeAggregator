using Newtonsoft.Json;
using ResumeAggregator.Models.E1;
using ResumeAggregator.Models.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace ResumeAggregator.Models
{
    public class E1toInternalSaveHelper
    {
        public static void ParseE1(E1CV cvCollection)
        {
            foreach (Resume resume in cvCollection.resumes)
            {
                ParseE1Resume(resume);
            }
        }

        public static HttpResponseMessage ParseE1Resume(Resume resume)
        {
            int idx;
            InnerCV innerCV = new InnerCV()
            {
                Id = resume.id,
                AddDate = string.IsNullOrWhiteSpace(resume.add_date) ? (DateTime?)null : DateTime.Parse(resume.add_date),
                Age = resume.age,
                Birthday = resume.birthday,
                CanAcceptReplies = resume.can_accept_replies == "True" ? 1 : 0,
                DriversLicenses = resume.drivers_licenses,
                EducationDescription = resume.education_description,
                EducationSpecialty = resume.education_specialty,
                Experience = resume.experience,
                HasChild = resume.has_child == "True" ? 1 : 0,
                Header = resume.header,
                HideBirthday = resume.hide_birthday == "True" ? 1 : 0,
                Info = resume.info,
                InfoShort = resume.info_short,
                Institution = resume.institution,
                IsDriver = resume.is_driver == "True" ? 1 : 0,
                IsJourney = resume.is_journey == "True" ? 1 : 0,
                IsSmoke = resume.is_smoke == "True" ? 1 : 0,
                MaritalStatus = resume.marital_status,
                ModDate = string.IsNullOrWhiteSpace(resume.mod_date) ? (DateTime?)null : DateTime.Parse(resume.mod_date),
                PersonalQualities = resume.personal_qualities,
                Removal = resume.removal,
                Salary = resume.salary,
                Sex = resume.sex,
                Skills = resume.skills,
                SurnameHide = resume.surname_hide == "True" ? 1 : 0,
                Url = resume.url,
                UrlDoc = resume.url_doc,
                UrlPdf = resume.url_pdf,
                WantedSalary = resume.wanted_salary,
                WantedSalaryRub = resume.wanted_salary_rub,
                WorkTimeTotalMonth = resume.work_time_total.month,
                WorkTimeTotalYear = resume.work_time_total.year
                /*,Cities
                ,Citizenship
                ,CitizenshipId
                ,Contact
                ,ContactId
                ,Currency
                ,CurrencyId
                ,Education
                ,EducationId
                ,ExpirienceLength
                ,ExpirienceLengthId
                ,Institutions
                ,Jobs
                ,Photo
                ,PhotoId
                ,Recommendations
                ,Rubrics
                ,schedule
                ,ScheduleId
                ,SecondaryEducations
                ,WorkingType
                ,WorkingtypeId*/
            };

            List<InnerCity> cities = new List<InnerCity>();
            foreach (City city in resume.cities_references)
            {
                cities.Add(new InnerCity() { Id = city.id, Title = city.title, Locative = city.locative });
            } 
            innerCV.Cities = cities;

            List<InnerInstitutionCollection> institutions = new List<InnerInstitutionCollection>();
            idx = 0;
            foreach (InstitutionCollection institution in resume.institutions)
            {
                idx++;
                institutions.Add(new InnerInstitutionCollection() {
                    City =institution.city,
                    CityId = institution.city.id,
                    DateFrom = institution.date.from.date,
                    DateTo = institution.date.to.date,
                    Faculty = institution.faculty,
                    FacultyId = institution.faculty.id,
                    Form = institution.form,
                    FormId = institution.form.id,
                    Speciality = institution.speciality,
                    SpecialityId = institution.speciality.id,
                    Id = idx
                });
            }
            innerCV.Institutions = institutions;

            List<InnerJob> jobs = new List<InnerJob>();
            idx = 0;
            foreach (Job job in resume.jobs)
            {
                idx++;
                jobs.Add(new InnerJob()
                {
                    City = job.city,
                    CityId = job.city.id,
                    DateFrom = job.date.from.date,
                    DateTo = job.date.to.date,
                    Company = job.company,
                    CompanyId = job.company.id,
                    Description = job.description,
                    IsStillWorking = job.isStillWorking,
                    Position = job.position,
                    PositionId = job.position.id,
                    Id = idx
                });
            }
            innerCV.Jobs = jobs;


            using (var client = new HttpClient())
            {
                string url = HttpContext.Current.Request.Url.AbsoluteUri;
                client.BaseAddress = new Uri("http://localhost:34663/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json")); 

                return client.PostAsJsonAsync("api/InnerResumes", innerCV).Result;
            }

        }
    }
}