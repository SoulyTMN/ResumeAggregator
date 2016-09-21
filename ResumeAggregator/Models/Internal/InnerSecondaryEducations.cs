using ResumeAggregator.Models.E1;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ResumeAggregator.Models.Internal
{
    public class InnerSecondaryEducations
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string CourseName { get; set; }
        public string Date { get; set; }
        public int? CityId { get; set; }
        [ForeignKey("CityId")]
        public InnerCity City { get; set; }
        public List<InnerCV> CVs { get; set; }
    }
}