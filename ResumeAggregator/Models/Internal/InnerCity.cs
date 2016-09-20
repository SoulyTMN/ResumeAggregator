using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeAggregator.Models.Internal
{
    public class InnerCity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Locative { get; set; }

        public List<InnerCV> CVs { get; set; }
    }
}