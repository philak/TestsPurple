
using PurpleBrick.ExecuteClass.Pages;
using PurpleBrick.PurpleBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace PurpleBrick.ExecuteClass.StepsDefinition
{
    [Binding]
    public class HomePageStep : BaseStep
    {
        HomeLandingPage homePage;
        
        
        [Given(@"I navigate to purplebricks home page on a system with configuration '(.*)'")]
        public void GivenINavigateToPurplebricksHomePageOnASystemWithConfiguration(string configuration)
        {
            BrowserBase Launch = new BrowserBase();
            Launch.OpenApplication(configuration);
        }

        [When(@"I click on the no thank button")]
        public void WhenIClickOnTheNoThankButton()
        {
            homePage = new HomeLandingPage(DriverRunner.driver);
           
            homePage.ClickNoThanksButton();
        }

    }
}
