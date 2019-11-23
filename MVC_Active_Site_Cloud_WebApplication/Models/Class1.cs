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
        public string country { get; set; }
        public string city { get; set; }
        public string reason_for_recall { get; set; }
        public string address_1 { get; set; }
        
        public string code_info { get; set; }
        public string product_quantity { get; set; }
        public string center_classification_date { get; set; }
        public string distribution_pattern { get; set; }
        public string state { get; set; }
        public string product_description { get; set; }
        public string report_date { get; set; }
    }

    public class food_recall
    {
        public string country { get; set; }
        public string city { get; set; }
        public string reason_for_recall { get; set; }
        public string address_1 { get; set; }
        public string address_2 { get; set; }
        public string code_info { get; set; }
        public string product_quantity { get; set; }
        public string center_classification_date { get; set; }
        public string distribution_pattern { get; set; }
        public string state { get; set; }
        public string product_description { get; set; }
        public string report_date { get; set; }
    }
}
