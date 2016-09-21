using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ResumeAggregator.Models.E1
{
    public class Contact
    {
        public int id { get; set; }
        public string name { get; set; }
        public string firstname { get; set; }
        public string patronymic { get; set; }
        public string street { get; set; }
        public string building { get; set; }
        public string room { get; set; }
        public int? SubwayId { get; set; }
        [ForeignKey("SubwayId")]
        public Subway subway { get; set; }
        public int? DistrictId { get; set; }
        [ForeignKey("DistrictId")]
        public District district { get; set; }
        public string address_description { get; set; }
        public string address { get; set; }
        public int? CityId { get; set; }
        [ForeignKey("CityId")]
        public City city { get; set; }
        public string icq { get; set; }
        public string skype { get; set; }
        public string url { get; set; }
        public string facebook { get; set; }
        public string moi_krug { get; set; }
        public string linkedin { get; set; }
        public string twitter { get; set; }
        public string vk { get; set; }
        public string use_messages { get; set; }

    }
}