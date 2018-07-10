using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Room5Test.Pages
{
    public class Newsletter : TestBase
    {
        private readonly IWebDriver _driver;

        [FindsBy(How = How.Id, Using = "confirm")]
        private IWebElement _newsletterCheckBox;

        [FindsBy(How = How.XPath, Using = "//div[@class='newsletter-email']/input")]
        private IWebElement _newsletterEmail;

        [FindsBy(How = How.XPath, Using = "//*[@id='app']/div[3]/div/div[6]/section/div/div/div[2]/div[3]/div[2]/button")]
        private IWebElement _newsletterSubmitBtn;

        [FindsBy(How = How.XPath, Using = "//p[@class='submitted h1'][contains(.,'You are now checked-in!')]")]
        private IWebElement _newsletterConfirmMsg;

        public Newsletter(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        //Navigate URL
        public static Newsletter NavigateTo(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(TestBase.PageUri);
            return new Newsletter(driver);
        }


        public void NewsletterCheckBox()
        {
            {
                _newsletterCheckBox.Click();
            }
        }

        public void NewsletterEmail()
        {
            {
                _newsletterEmail.SendKeys("zzz@yopmail.com");
            }
        }

        public void NewsletterSubmitBtn()
        {
            {
                _newsletterSubmitBtn.Click();
            }
        }

        public string NewsletterConfirmMsg()
        {
            {
                var _newsletterConfirmMsg = this._newsletterConfirmMsg.Text;
                return _newsletterConfirmMsg;
            }
        }
    }
}


