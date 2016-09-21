using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeAggregator.Models.E1
{
    public class City
    {
        public int? id { get; set; }
        public string title { get; set; }
        public string locative { get; set; }
        public IList<District> districts { get; set; }
        public IList<Subway> subways { get; set; }
    }
}