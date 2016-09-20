using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeAggregator.Models.E1
{
    public class Query
    {
        public IList<string> state { get; set; }
        public int visibility_type { get; set; }
        public string average_salary { get; set; }
        public int categories_facets { get; set; }
        public int city_id { get; set; }
        public string search_type { get; set; }
        public int geo_id { get; set; }
    }
}