using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeAggregator.Models.E1
{
    public class Rubric
    {
        public int id { get; set; }
        public string title { get; set; }
        public IList<Speciality> specialities { get; set; }
    }
}