using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using PurpleBrick.PurpleBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurpleBrick.ExecuteClass.Pages
{
    class HomeLandingPage
    {
        public HomeLandingPage(IWebDriver driver)
        {
            PageFactory.InitElements(DriverRunner.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[text()='No thanks']")]
        private IWebElement NoThanksButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='top']//span[node()='Tour Lists']")]
        private IWebElement TourLists { get; set; }


       

        public HomeLandingPage ClickNoThanksButton()
        {
            NoThanksButton.Click();
            return new HomeLandingPage(DriverRunner.driver);
        }
        public TourListPage OpenTourListsPage()
        {
            TourLists.Click();
            return new TourListPage(DriverRunner.driver);
        }
   
       
    }
}
