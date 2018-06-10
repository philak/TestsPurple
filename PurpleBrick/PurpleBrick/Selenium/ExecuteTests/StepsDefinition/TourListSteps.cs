using PurpleBrick.ExecuteClass.Pages;
using PurpleBrick.PurpleBase;
using System;
using TechTalk.SpecFlow;

namespace PurpleBrick
{
    [Binding]
    public class TourListSteps : BaseStep
    {
        TourListPage TourList;

        [Given(@"I click Tour list button on marketing site")]
        public void GivenIClickTourListButtonOnMarketingSite()
        {
            HomeLandingPage land= new HomeLandingPage(DriverRunner.driver);
            TourList = land.OpenTourListsPage();
        }
        
        [Given(@"I see and type into empty text field to add a name for my Tour list '(.*)'")]
        public void GivenISeeAndTypeIntoEmptyTextFieldToAddANameForMyTourList(string tourListName)
        {   
            TourList.FieldEmptyThenEnterTourListName(tourListName);
        }
        
        [Given(@"I click Create Tour List button")]
        public void GivenIClickCreateTourListButton()
        {
            TourList.ClickCreateTourListButton();
        }
        
        [Given(@"the new tour list should be created")]
        public void GivenTheNewTourListShouldBeCreated()
        {
            TourList.TourListsVisible();
        }
        
        [Given(@"I delete the created tourList")]
        public void GivenIDeleteTheCreatedTourList()
        {
            TourList.DeleteCreatedTourList();
        }
        
        [Then(@"the tourList should be deleted")]
        public void ThenTheTourListShouldBeDeleted()
        {
            TourList.TourListNotPresent();
        }

        [AfterFeature]
        private static void AfterFeature()
        {
            DriverRunner.driver.Close();
            DriverRunner.driver.Quit();
        }
    }
}
