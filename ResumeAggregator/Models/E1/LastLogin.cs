using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeAggregator.Models.E1
{
    public class LastLogin
    {
        public int reason_id { get; set; }
        public string reason { get; set; }
        public int user_id { get; set; }
        public E1Date created_at { get; set; }
    }
}