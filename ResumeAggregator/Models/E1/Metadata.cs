using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeAggregator.Models.E1
{
    public class Metadata
    {
        public Query query { get; set; }
        public IList<Category> categories_facets { get; set; }
        public int average_salary { get; set; }
        public IList<Deprecation> deprecations { get; set; }
        public ResultSet resultset { get; set; }
    }
}