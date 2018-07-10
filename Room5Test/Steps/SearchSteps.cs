using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using Xunit;

namespace Room5Test.Steps 
{
    [Binding]
    public class SearchSteps : TestBase
    {
        
        private IWebDriver _driver;
        private Pages.Search _searchPage;

        

        [Given(@"I am on Room(.*) landing page")]
        public void GivenIAmOnRoomLandingPage(int p0)
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            // _driver.Navigate().GoToUrl("http://room5.trivago.com/");
            _searchPage = Pages.Search.NavigateTo(_driver);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
        }

        [When(@"I click on search icon")]
        public void WhenIClickOnSearchIcon()
        {
            _searchPage.SearchIcon();
        }


        [When(@"I click on destination canada")]
        public void WhenIClickOnDestinationCanada()
        {
            _searchPage.DestinationCanada();
        }

        [When(@"I click on recommanded tags budget")]
        public void WhenIClickOnRecommandedTagsBudget()
        {
            _searchPage.TagsBudget();
        }

        [Then(@"single search result shows")]
        public void ThenSingleSearchResultShows()
        {
            Thread.Sleep(2000);
            Assert.Equal("CANADA", _searchPage.SearchResult());
        }

        [AfterScenario]
        public void DisposeWebDriver()
        {
            _driver.Dispose();
        }
    }
}
