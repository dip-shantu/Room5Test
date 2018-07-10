using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using Xunit;
using OpenQA.Selenium.Interactions;


namespace Room5Test.Steps
{
    [Binding]
    public class ContactSteps : TestBase
    {

        private IWebDriver _driver;
        private Pages.Contact _contactPage;

        [Given(@"I am on home page")]
        public void GivenIAmOnHomePage()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _contactPage = Pages.Contact.NavigateTo(_driver);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }


        [Given(@"I click contact link")]
        public void GivenIClickContactLink()
        {
            Thread.Sleep(5000);
            IWebElement element= _driver.FindElement(By.LinkText("Contact"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)_driver;
            jse.ExecuteScript("arguments[0].scrollIntoView();", element);

            _contactPage.SelectContact();
            Actions action = new Actions(_driver);
            action.KeyDown(Keys.Control).SendKeys(Keys.Tab).Build().Perform();
            Thread.Sleep(5000);
        }
        
        [Given(@"I enter message")]
        public void GivenIEnterMessage()
        {
            _contactPage.EnterMessage();
        }
        
        [Given(@"I enter name")]
        public void GivenIEnterName()
        {
            _contactPage.EnterName();
        }
        
        [Given(@"I enter email")]
        public void GivenIEnterEmail()
        {
            _contactPage.EnterEmail();
            Thread.Sleep(5000);
        }
        
        [Given(@"I select checkbox")]
        public void GivenISelectCheckbox()
        {
            _contactPage.ConfirmCheckBox();
        }
        
        [When(@"I press submit")]
        public void WhenIPressSubmit()
        {
            _contactPage.SubmitContactForm();
            Thread.Sleep(5000);
        }
        
        [Then(@"I get confirmation that message sent successfully")]
        public void ThenIGetConfirmationThatMessageSentSuccessfully()
        {
            Assert.Equal("Message Sent Successfully!", _contactPage.ContactConfirmMsg());
            _driver.Dispose();
        }
    }
}
