using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeAggregator.Models.E1
{
    public class InstitutionCollection
    {
        public City city { get; set; }
        public Form form { get; set; }
        public Faculty faculty { get; set; }
        public Speciality speciality { get; set; }
        public InstitutionDate  date { get; set; }
}
}