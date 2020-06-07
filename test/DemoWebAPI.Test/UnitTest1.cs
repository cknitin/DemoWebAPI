using System;
using Xunit;
using DemoWebAPI.Controllers;

namespace DemoWebAPI.Test
{
    public class UnitTest1
    {

        WeatherForecastController controller = new WeatherForecastController();
        [Fact]
        public void Test1()
        {
            var returnValue = controller.GetWeatherName();
            Assert.Equal("winter", returnValue.ToString());
        }
    }
}
