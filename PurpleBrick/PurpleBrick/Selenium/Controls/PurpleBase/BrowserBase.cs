using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurpleBrick.PurpleBase
{


    public class BrowserBase
    {
       protected IWebDriver driver;

        String browserName = "Chrome";

        public void OpenApplication(string url)
        {
            LauncnBrowser(browserName, url);
        }
        public void LauncnBrowser(String browsername, String url)
        {
            if (browsername.Equals("firefox"))
            {

                DriverRunner.driver = new FirefoxDriver();
            
                DriverRunner.setDriver(DriverRunner.driver);
            }
            else if (browsername.Equals("Chrome"))
            {
                DriverRunner.driver = new ChromeDriver();
       
                DriverRunner.setDriver(DriverRunner.driver);
            }

            DriverRunner.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            DriverRunner.driver.Manage().Window.Maximize();
            DriverRunner.driver.Navigate().GoToUrl(url);
         
        }
    }
}
    
