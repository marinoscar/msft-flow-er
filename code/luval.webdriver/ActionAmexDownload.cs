using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luval.webdriver
{
    public class ActionAmexDownload
    {
        public ActionAmexDownload(IWebDriver driver, Dictionary<string, string> parameters)
        {
            Driver = driver;
            Parameters = parameters;
        }

        public IWebDriver Driver { get; private set; }
        public Dictionary<string, string> Parameters { get; private set; }

        public void Execute()
        {
            LoginToAmex();
            LogoutFromAmex();
        }

        private void LoginToAmex()
        {
            Driver.Navigate().GoToUrl(Parameters["loginUrl"]);
            Driver.WaitForPageLoad();
            var userEL = Driver.FindElement(By.Id("eliloUserID"));
            userEL.SendKeys(Parameters["userName"]);
            var passwordEl = Driver.FindElement(By.Id("eliloPassword"));
            passwordEl.SendKeys(Parameters["password"]);
            var loginEl = Driver.FindElement(By.Id("loginSubmit"));
            loginEl.Click();
        }

        private void LogoutFromAmex()
        {
            Driver.WaitForPageLoad();
            var logout = FindLogout();
            logout.Click();
        }

        private IWebElement FindLogout()
        { 
            var el = Driver.FindElement(By.XPath(@"//span[contains(text(), 'Log Out')]"));
            return el;
        }
    }
}
