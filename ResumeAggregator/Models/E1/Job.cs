using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeAggregator.Models.E1
{
    public class Job
    {
        public JobsDate date { get; set; }
        public City city { get; set; }
        public Position position { get; set; }
        public Company company { get; set; }
        public string description { get; set; }
        public string isStillWorking { get; set; }
    }
}