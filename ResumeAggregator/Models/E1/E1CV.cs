using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeAggregator.Models.E1
{
    public class E1CV
    {
        public Metadata metadata;
        public IList<Resume> resumes;
    }
}