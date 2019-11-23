using luval.webdriver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luval.er.terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            var action = new ActionAmexDownload(DriverFactory.Create(), new Dictionary<string, string>() {
                { "loginUrl", "https://global.americanexpress.com/login" },
                { "userName", ConfigurationManager.AppSettings["userName"]},
                { "password", ConfigurationManager.AppSettings["password"]},
            });
            action.Execute();
        }
    }
}
