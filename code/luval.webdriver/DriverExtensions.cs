using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luval.webdriver
{
    public static class DriverExtensions
    {
        public static void WaitForPageLoad(this IWebDriver driver)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(15)).Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
        }

        public static void WaitForPageLoad(this IWebDriver driver, TimeSpan timeSpan)
        {
            new WebDriverWait(driver, timeSpan).Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
        }
    }
}
