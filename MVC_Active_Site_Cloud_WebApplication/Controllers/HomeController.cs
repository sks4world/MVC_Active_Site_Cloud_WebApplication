using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using MVC_Active_Site_Cloud_WebApplication.Models;
using Newtonsoft.Json.Linq;

namespace MVC_Active_Site_Cloud_WebApplication.Controllers
{
    public class HomeController : Controller
    {
        //private readonly IRepository _repository;
        //string BASE_URL = "https://api.iextrading.com/1.0/";
        string BASE_URL = "https://api.fda.gov/food/enforcement.json";
        HttpClient httpClient;

        public HomeController( )
        {
            //_repository = repository;
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new
            System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
        public List<drug_recall> GetRecalls()
        {
            string Foodrecall_API = BASE_URL + "?search=report_date:[20040101+TO+20131231]&limit=10";
            //string Foodrecall_API = BASE_URL + "ref-data/symbols";
            string recalllist = "";
            List<drug_recall> samples = null;

            httpClient.BaseAddress = new Uri(Foodrecall_API);
            HttpResponseMessage response = httpClient.GetAsync(Foodrecall_API).GetAwaiter().GetResult();

            if(response.IsSuccessStatusCode)
            {
                recalllist = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                //string results = recalllist.Substring(700, 2671);
            }

             if(!recalllist.Equals(""))
            {
                JObject recallJson = JObject.Parse(recalllist);
                //JObject resultsObject = (JObject)recallJson["results"];
                JArray resultsArray = (JArray)recallJson["results"];
                string resultsString = resultsArray.ToString();
                samples = JsonConvert.DeserializeObject<List<drug_recall>>(resultsString);
                samples = samples.GetRange(0,10);

            }
            return samples;

        }


        public IActionResult Index()
        {
            List<drug_recall> output = GetRecalls();
            return View(output);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
 
        public IActionResult Food()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
    }
}
