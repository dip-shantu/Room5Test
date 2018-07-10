using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using Xunit;

namespace Room5Test.Steps
{
    [Binding]
    public class NewsletterSteps : TestBase
    {

        private IWebDriver _driver;
        private Pages.Newsletter _newsletterPage; 

        [Given(@"I am on landing page")]
        public void GivenIAmOnLandingPage()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _newsletterPage = Pages.Newsletter.NavigateTo(_driver);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
        }

        [Given(@"I enter email address")]
        public void GivenIEnterEmailAddress()
        {
            _newsletterPage.NewsletterEmail();
        }

        [Given(@"I click on accept checkbox")]
        public void GivenIClickOnAcceptCheckbox()
        {
            Thread.Sleep(3000);
            _newsletterPage.NewsletterCheckBox();
        }
        
        [When(@"I click Inspire me button")]
        public void WhenIClickInspireMeButton()
        {
            _newsletterPage.NewsletterSubmitBtn();
            Thread.Sleep(5000);
        }
        
        [Then(@"newsletter subscription confirmation message shows")]
        public void ThenNewsletterSubscriptionConfirmationMessageShows()
        {
            Assert.Equal("You are now checked-in!", _newsletterPage.NewsletterConfirmMsg());
            Thread.Sleep(5000);
            _driver.Dispose();
        }
    }
}
