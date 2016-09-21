using ResumeAggregator.Models.E1;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ResumeAggregator.Models.Internal
{
    public class InnerInstitutionCollection
    {
        public int Id { get; set; }
        public int? CityId { get; set; }
        [ForeignKey("CityId")]
        public City City { get; set; }
        public int? FormId { get; set; }
        [ForeignKey("FormId")]
        public Form Form { get; set; }
        public int? FacultyId { get; set; }
        [ForeignKey("FacultyId")]
        public Faculty Faculty { get; set; }
        public int? SpecialityId { get; set; }
        [ForeignKey("SpecialityId")]
        public Speciality Speciality { get; set; }
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
        public List<InnerCV> CVs { get; set; }
    }
}