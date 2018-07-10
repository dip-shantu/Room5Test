using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using Xunit;
namespace Room5Test.Steps
{
    [Binding]
    public class DestinationSteps : TestBase
    {
        private IWebDriver _driver;
        private Pages.Destination _destinationPage;

        [Given(@"I am on magazine home page")]
        public void GivenIAmOnMagazineHomePage()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _destinationPage = Pages.Destination.NavigateTo(_driver);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
        }
        
        [Given(@"I click on menu")]
        public void GivenIClickOnMenu()
        {
            _destinationPage.DestinationNavIcon();
        }
        
        [Given(@"I click on a destination item")]
        public void GivenIClickOnADestinationItem()
        {
            _destinationPage.DestinationWest();
            Thread.Sleep(3000);
        }
        
        [When(@"I click on final destination")]
        public void WhenIClickOnFinalDestination()
        {
            IWebElement element = _driver.FindElement(By.XPath("//div[@class='destination-page-post-section']//section[1]//div[1]//div[1]//a[1]"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)_driver;
            jse.ExecuteScript("arguments[0].scrollIntoView();", element);
            _destinationPage.DestinationArticalTile();
        }
        
        [Then(@"I land on final destination artical")]
        public void ThenILandOnFinalDestinationArtical()
        {
            Assert.Equal("Vegas Pool Parties: The Five Best Parties to Hit Up in Sin City", _destinationPage.DestinationConfirmHeader());
            Thread.Sleep(5000);
            _driver.Dispose();
        }
    }
}
