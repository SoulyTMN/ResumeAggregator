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
                WorkTimeTotalYear = resume.work_time_total.year,
                Citizenship = resume.citizenship,
                CitizenshipId = resume.citizenship?.id,
                //Contact = resume.contact,
                //ContactId = resume.contact?.id,
                Currency = resume.currency,
                CurrencyId = resume.currency?.id,
                Education = resume.education,
                EducationId = resume.education?.id,
                ExpirienceLength = resume.expirience_length,
                ExpirienceLengthId = resume.expirience_length?.id,
                /*Photo = resume.photo,
               PhotoId = resume.photo?.id,*/
                schedule = resume.schedule,
                ScheduleId = resume.schedule?.id,
                WorkingType = resume.working_type,
                WorkingtypeId = resume.working_type?.id
            };

            List<InnerCity> cities = new List<InnerCity>();
            foreach (City city in resume.cities_references)
            {
                cities.Add(ParseCity(city));
            }
            innerCV.Cities = cities;

            List<InnerInstitutionCollection> institutions = new List<InnerInstitutionCollection>();
            foreach (InstitutionCollection institution in resume.institutions)
            {
                institutions.Add(new InnerInstitutionCollection()
                {
                    City = ParseCity(institution.city),
                    CityId = institution.city?.id,
                    DateFrom = institution.date.from.date,
                    DateTo = institution.date.to.date,
                    Faculty = institution.faculty,
                    FacultyId = institution.faculty?.id,
                    Form = institution.form,
                    FormId = institution.form?.id,
                    Speciality = institution.speciality,
                    SpecialityId = institution.speciality?.id
                });
            }
            innerCV.Institutions = institutions;

            List<InnerJob> jobs = new List<InnerJob>();
            foreach (Job job in resume.jobs)
            {
                jobs.Add(new InnerJob()
                {
                    City = ParseCity(job.city),
                    CityId = job.city?.id,
                    DateFrom = job.date.from.date,
                    DateTo = job.date.to.date,
                    Company = job.company,
                    CompanyId = job.company?.id,
                    Description = job.description,
                    IsStillWorking = job.isStillWorking,
                    Position = job.position,
                    PositionId = job.position?.id
                });
            }
            innerCV.Jobs = jobs;

            List<InnerRecommendation> recommendations = new List<InnerRecommendation>();
            foreach (Recommendation recommendation in resume.recommendations)
            {
                recommendations.Add(new InnerRecommendation()
                {
                    City = ParseCity(recommendation.city),
                    CityId = recommendation.city?.id,
                    Fullname = recommendation.fullname,
                    Phone = recommendation.phone.phone,
                    PhoneComment = recommendation.phone.comment,
                    Company = recommendation.company,
                    CompanyId = recommendation.company?.id,
                    Position = recommendation.position,
                    PositionId = recommendation.position?.id

                });
            }
            innerCV.Recommendations = recommendations;

            List<InnerRubric> rubrics = new List<InnerRubric>();
            foreach (Rubric rubric in resume.rubrics)
            {
                if (rubric?.id != null)
                    rubrics.Add(new InnerRubric()
                    {
                        id = rubric.id ?? 0,
                        title = rubric.title
                    });
            }
            innerCV.Rubrics = rubrics;

            List<InnerSecondaryEducations> secondaryEducations = new List<InnerSecondaryEducations>();
            foreach (SecondaryEducations se in resume.secondary_educations)
            {
                secondaryEducations.Add(new InnerSecondaryEducations()
                {
                    City = ParseCity(se.city),
                    CityId = se.city?.id,
                    CompanyName = se.company_name,
                    CourseName = se.course_name,
                    Date = se.finish_date.date

                });
            }
            innerCV.SecondaryEducations = secondaryEducations;
            
            using (var client = new HttpClient())
            {
                var request = HttpContext.Current.Request.Url;
                string url = string.Format("{0}://{1}/", request.Scheme, request.Authority);
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                return client.PostAsJsonAsync("api/InnerResumes", innerCV).Result;
            }

        }

        public static InnerCity ParseCity(City city)
        {
            if (city?.id == null)
                return null;
            else
                return new InnerCity() { Id = city.id ?? 0, Title = city.title, Locative = city.locative };
        }

    }
}