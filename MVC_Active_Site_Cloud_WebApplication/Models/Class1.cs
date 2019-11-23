using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Active_Site_Cloud_WebApplication.Models
{
    public class country
    {
        public string country_id { get; set; }
        public string country_code { get; set; }
        public string country_name { get; set; }

    }

    public class yearClass
    {
        public int year_id { get; set; }
        public int year { get; set; }

    }

    public class city
    {
        public int city_id { get; set; }
        public string city_code { get; set; }
        public string city_description { get; set; }

    }

    public class drug_recall
    {
        public string product { get; set; }
        public string recall_initiation_date { get; set; }
        public string classification { get; set; }
        public string Reason_for_recall { get; set; }
        public string isVoluntary { get; set; }
        public string country_id { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string distribution_coverage { get; set; }
    }

    public class food_recall
    {
        public string product { get; set; }
        public string recall_initiation_date { get; set; }
        public string classification { get; set; }
        public string Reason_for_recall { get; set; }
        public string isVoluntary { get; set; }
        public string country_id { get; set; }
        public string city_id { get; set; }
        public string state { get; set; }
        public string distribution_coverage { get; set; }
    }
}
