using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeAggregator.Models.Internal
{
    public class InnerRubric
    {
        public int id { get; set; }
        public string title { get; set; }
        public List<InnerCV> CVs { get; set; }
    }
}