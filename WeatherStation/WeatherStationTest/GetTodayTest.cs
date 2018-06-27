using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeatherStation.Model.Services;

namespace WeatherStationTest
{
    [TestClass]
    public class GetTodayTest
    {
        DataAccessServices dataAccessServices = new DataAccessServices();

        [TestMethod]
        public void TodayTest()
        {
            dataAccessServices.GetToday(
                (item, error) =>
                {
                    Assert.IsNotNull(error);
                    Assert.IsNull(item);
                }
            , "Rzeszow");
        }
    }
}
