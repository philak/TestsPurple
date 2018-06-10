using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using PurpleBrick.PurpleBase;

namespace PurpleBrick.ExecuteClass.Pages
{
    public class TourListPage
    {
       

        public TourListPage(IWebDriver driver)
        {
            PageFactory.InitElements(DriverRunner.driver, this);
        }

        [FindsBy(How = How.Name, Using = "createTour")]
        private IWebElement TourListFieldName { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@value='Create Tour List']")]
        private IWebElement CreateTourListButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='style_placeholder_3o_cZ']")]
        private IWebElement CreatedTourListImage { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='style_delete_3ajjt']")]
        private IWebElement DeleteButton { get; set; }



        public TourListPage FieldEmptyThenEnterTourListName(string TourListName)
        {
            var emptyField = TourListFieldName.Text;

            if (string.IsNullOrEmpty(emptyField))
            {
                TourListFieldName.SendKeys(TourListName);
            }
            else
            {
                Assert.Fail("the text field is not empty", emptyField);
            }
            return new TourListPage(DriverRunner.driver);
        }

        public TourListPage ClickCreateTourListButton()
        {
            CreateTourListButton.Click();
            return new TourListPage(DriverRunner.driver);
        }


        public TourListPage TourListsVisible()
        {
             Utils.IsElementVisible(CreatedTourListImage);
            return new TourListPage(DriverRunner.driver);
        }

        public TourListPage TourListNotPresent()
        {
            Utils.VerifyElementAbsent(CreatedTourListImage);
            return new TourListPage(DriverRunner.driver);
        }

        public TourListPage DeleteCreatedTourList()
        {
            DeleteButton.Click();
            return new TourListPage(DriverRunner.driver);
        }

    }
}