using ResumeAggregator.Models.E1;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ResumeAggregator.Models.Internal
{
    public class InnerRecommendation
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        [ForeignKey("CityId")]
        public City City { get; set; }
        public int CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public Company Company { get; set; }
        public string Phone { get; set; }
        public string PhoneComment { get; set; }
        public string Fullname { get; set; }
        public int PositionId { get; set; }
        [ForeignKey("PositionId")]
        public Position Position { get; set; }
        public List<InnerCV> CVs { get; set; }
    }
}