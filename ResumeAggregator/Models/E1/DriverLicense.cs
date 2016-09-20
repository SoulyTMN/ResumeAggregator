using ResumeAggregator.Models.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeAggregator.Models.E1
{
    public class DriverLicense
    {
        public int id { get; set; }
        public string title { get; set; }
        public List<InnerCV> CVs { get; set; }
    }
}