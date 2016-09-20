using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeAggregator.Models.E1
{
    public class Recommendation
    {
        public City city { get; set; }
        public Company company { get; set; }
        public Phone phone { get; set; }
        public string fullname { get; set; }
        public Position position { get; set; }
    }
}