using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace WooliesX_WeatherMap
{

      [Binding]
      public class HolidayMaker
    {

        private WebService service = new WebService();


        [Given(@"I like to holiday in Sydney")]
        public void GivenILikeToHolidayInSydney()
        {
            service.SetCity();
        }

        [Given(@"I only like to holiday on Thursdays")]
        public void GivenIOnlyLikeToHolidayOnThursdays()
        {
            ///
        }

        [When(@"I look up the weather forecast")]
        public void WhenILookUpTheWeatherForecast()
        {
            service.CreateRequest();
        }

        [Then(@"I receive the weather forecast")]
        public void ThenIReceiveTheWeatherForecast()
        {
            service.ValidateJson();
            service.ConfirmLocation();
        }

        [Then(@"the temperature is warmer than (.*) degrees")]
        public void ThenTheTemperatureIsWarmerThanDegrees(int temp)
        {
            service.ConfirmTemperature(temp);
        }

    }
}
