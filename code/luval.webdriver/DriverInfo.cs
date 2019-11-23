using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luval.webdriver
{
    public class DriverInfo
    {
        public FileInfo File { get; set; }
        public int Port { get; set; }

        public DriverInfo(string path, int port)
        {
            File = new FileInfo(path);
            Port = port;
        }

        public DriverInfo(string path) : this(path, 17556)
        {
           
        }

        public DriverInfo(): this(GetDriverServiceLocation(DriverType.None))
        {

        }

        public DriverInfo(DriverType driverType) : this(GetDriverServiceLocation(DriverType.None))
        {

        }

        public static string GetDriverServiceLocation(DriverType driverType)
        {
            switch (driverType)
            {
                case DriverType.None:
                    return @"C:\Git\msft-flow-er\drivers\MicrosoftWebDriver.exe";
                case DriverType.Edge:
                    return @"C:\Git\msft-flow-er\drivers\MicrosoftWebDriver.exe";
                case DriverType.IE:
                    return @"C:\Git\msft-flow-er\drivers\MicrosoftWebDriver.exe";
                case DriverType.Chrome:
                    return @"C:\Git\msft-flow-er\drivers\MicrosoftWebDriver.exe";
                default:
                    return @"C:\Git\msft-flow-er\drivers\MicrosoftWebDriver.exe";
            }
        }
    }

    public enum DriverType { None, Edge, IE, Chrome }
}
