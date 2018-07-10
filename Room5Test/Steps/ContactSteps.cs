using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using Xunit;
using OpenQA.Selenium.Interactions;

namespace Room5Test.Steps
{
    [Binding]
    public class ContactSteps : TestBase
    {

        public IWebDriver _driver;
        public Pages.Contact _contactPage;



        [Given(@"I click contact link")]
        public void GivenIClickContactLink()
        {
            Thread.Sleep(5000);
            _contactPage.SelectContact();
            //Actions action = new Actions(_driver); action.KeyDown(Keys.Control).KeyDown(Keys.Shift).SendKeys(Keys.Tab).Build().Perform();
            Thread.Sleep(5000);
        }
        
        [Given(@"I enter message")]
        public void GivenIEnterMessage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I enter name")]
        public void GivenIEnterName()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I enter email")]
        public void GivenIEnterEmail()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I select checkbox")]
        public void GivenISelectCheckbox()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press submit")]
        public void WhenIPressSubmit()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I get confirmation that message sent successfully")]
        public void ThenIGetConfirmationThatMessageSentSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
