using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurpleBrick.PurpleBase
{


    public class DriverRunner : BrowserBase
    {
        public new static IWebDriver driver;

        public static void setDriver(IWebDriver _driver)
        {
            _driver = driver;
        }
    }
}
