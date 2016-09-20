using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeAggregator.Models.E1
{
    public class SecondaryEducations
    {
        public string company_name { get; set; }
        public string course_name { get; set; }
        public E1Date finish_date { get; set; }
        public City city { get; set; }
    }
}