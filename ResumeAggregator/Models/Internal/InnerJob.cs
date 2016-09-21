using ResumeAggregator.Models.E1;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ResumeAggregator.Models.Internal
{
    public class InnerJob
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
        public int? CityId { get; set; }
        [ForeignKey("CityId")]
        public InnerCity City { get; set; }
        public int? PositionId { get; set; }
        [ForeignKey("PositionId")]
        public Position Position { get; set; }
        public int? CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public Company Company { get; set; }
        public string Description { get; set; }
        public string IsStillWorking { get; set; }
        public List<InnerCV> CVs { get; set; }
    }
}