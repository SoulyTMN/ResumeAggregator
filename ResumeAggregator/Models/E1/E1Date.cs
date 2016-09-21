using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeAggregator.Models.E1
{
    public class E1Date
    {
        public string date { get; set; }
        public int? year { get; set; }
        public int? month { get; set; }
        public int? timezone_type { get; set; }
        public string timezone { get; set; }
    }
}