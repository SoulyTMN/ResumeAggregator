using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeAggregator.Models.E1
{
    public class ResultSet
    {
        public int? count { get; set; }
        public int? limit { get; set; }
        public int? offset { get; set; }
    }
}