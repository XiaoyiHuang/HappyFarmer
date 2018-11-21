using System;
using System.Collections.Generic;
using System.Web.Mvc;
using QuickTypeDeviceData;
using RestSharp;
using RestSharp.Authenticators;


namespace HappyFarmer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
        public ActionResult WeatherData()
        {
            var client = new RestClient();
            client.BaseUrl = new Uri("https://api.ambientweather.net");
            //client.Authenticator = new HttpBasicAuthenticator("username", "password");

            var request = new RestRequest();
            request.Resource = "v1/devices/";
            var applicationKey = new Parameter("applicationKey", "1c790b09742a40b494d4c2fc98e5bea240cb433303ea4f65bb3699ade56baeeb", ParameterType.QueryString);
            var apiKey = new Parameter("apiKey", "1e496310ad4443a48e275ce5c16cc59da0a6afca1bfa49dab8840c3a11c566bb", ParameterType.QueryString);
            request.Parameters.Add(applicationKey);
            request.Parameters.Add(apiKey);
            IRestResponse response = client.Execute(request);
            var welcome = Welcome.FromJson(response.Content.ToString());
            List<Welcome> welcomeList = welcome;
            foreach(var item in (List<Welcome>) welcomeList)
            {
                Console.WriteLine(item.MacAddress);
                
            }
            //Console.WriteLine(welcome.ToString());
            return View();
        }
        
        public ActionResult SoilData()
        {
            var client = new RestClient();
            client.BaseUrl = new Uri("https://api.thingspeak.com");
            //client.Authenticator = new HttpBasicAuthenticator("username", "password");
            var todaysDate = DateTime.UtcNow.ToString("s") + "Z";
            var request = new RestRequest();
            request.Resource = "channels/621588/feeds/";
            var startDate = new Parameter("start", "2018-11-08T00:47:24Z", ParameterType.QueryString);
            var endDate = new Parameter("end", todaysDate, ParameterType.QueryString);
            request.Parameters.Add(startDate);
            request.Parameters.Add(endDate);
            IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content.ToString());
            return View();
        }
        
        public ActionResult DeviceData()
        {
            var client = new RestClient();
            client.BaseUrl = new Uri("https://api.ambientweather.net");
            //client.Authenticator = new HttpBasicAuthenticator("username", "password");

            var request = new RestRequest();
            request.Resource = "v1/devices/";
            var applicationKey = new Parameter("applicationKey", "1c790b09742a40b494d4c2fc98e5bea240cb433303ea4f65bb3699ade56baeeb", ParameterType.QueryString);
            var apiKey = new Parameter("apiKey", "1e496310ad4443a48e275ce5c16cc59da0a6afca1bfa49dab8840c3a11c566bb", ParameterType.QueryString);
            request.Parameters.Add(applicationKey);
            request.Parameters.Add(apiKey);
            IRestResponse response = client.Execute(request);
            var welcome = Welcome.FromJson(response.Content.ToString());
            List<Welcome> welcomeList = welcome;
            foreach(var item in (List<Welcome>) welcomeList)
            {
                //ViewBag.MacAddress = item.MacAddress;
            }
            //Console.WriteLine(welcome.ToString());
            return View();
        }

        public new ActionResult Profile()
        {
            return View();
        }

        public ActionResult Map()
        {
            return View();
        }

        public ActionResult Tables()
        {
            return View();
        }
    }
}