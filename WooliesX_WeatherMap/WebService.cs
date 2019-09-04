using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using TechTalk.SpecFlow;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
namespace WooliesX_WeatherMap
{
    public class WebService
    {

        private string ApiURL = ConfigurationManager.AppSettings["Endpoint"];
        private string ApiKey = ConfigurationManager.AppSettings["APIKey"];
        private string City = null;
     //   private string ApiKey = ConfigurationManager.AppSettings["APIKey"];

 
        string Units = "metric";
       // int Count = 16;
        string Response=null;
        JObject JsonResponse = null;
        bool ValidJson = false;

        StringBuilder APIURL = new StringBuilder();
        

   

        public void SetCity()
        {

            City = ConfigurationManager.AppSettings["City"];
            
        }

        


        public void CreateRequest()
        {
            using (WebClient client = new WebClient())

            {
                string fullurl= string.Format("{0}?q={1}&appid={2}&units={3}", ApiURL, City, ApiKey, Units);
                client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                Response = client.DownloadString(string.Format("{0}?q={1}&appid={2}&units={3}", ApiURL, City, ApiKey, Units));
            }
        }


        public void ValidateJson()
        {
            try
            {
              JsonResponse= JObject.Parse(Response);
                ValidJson = true;
            }

            catch (FormatException fex)
            {
                //Invalid json format
                Console.WriteLine(fex);
                
            }
            Assert.IsTrue(ValidJson,"Invalid JSON");
        }


        public void ConfirmLocation()
        {
            Assert.AreEqual("Sydney", JsonResponse["name"].ToString(),"Location is wrong");
            Assert.AreEqual("AU", JsonResponse["sys"]["country"].ToString(),"CountryCode is wrong");
          
         }


        public void ConfirmTemperature(int temp )
        {

            Assert.IsTrue(decimal.Parse(JsonResponse["main"]["temp_min"].ToString()) > 10, "Minimum Temp is less than 10 ");

        }


    }
}