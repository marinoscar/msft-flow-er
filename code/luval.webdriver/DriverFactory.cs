using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luval.webdriver
{
    public class DriverFactory
    {
        public static IWebDriver Create()
        {
            return CreateEdgeDriver();
        }

        public static EdgeDriver CreateEdgeDriver()
        {
            var driverInfo = new DriverInfo();
            var driverOptions = new EdgeOptions();
            var driverService = EdgeDriverService.CreateDefaultService(driverInfo.File.DirectoryName, driverInfo.File.Name, driverInfo.Port);
            return new EdgeDriver(driverService, driverOptions, TimeSpan.FromSeconds(15));
        }
    }
}
