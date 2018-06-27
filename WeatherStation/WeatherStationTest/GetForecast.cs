using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeatherStation.Model.Services;

namespace WeatherStationTest
{
    [TestClass]
    public class GetForecastTest
    {
        DataAccessServices dataAccessServices = new DataAccessServices();

        [TestMethod]
        public void ForecastTest()
        {
            dataAccessServices.GetForecast(
                (item, error) =>
                {
                    Assert.IsNotNull(error);
                    Assert.IsNull(item);
                }
            , "Rzeszow");
        }
    }
}
