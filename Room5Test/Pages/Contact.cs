using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Room5Test.Pages
{
    public class Contact : TestBase
    {
        private readonly IWebDriver _driver;

        [FindsBy(How = How.LinkText, Using = "Contact")]
        private IWebElement _contactLink;

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[3]/div[1]/div[1]/div[1]/div[2]/div[1]/textarea[1]")]
        private IWebElement _contactMsgFld;

        [FindsBy(How = How.XPath, Using = "(//input[@class='contact-input'])")]
        private IWebElement _nameFld;

        [FindsBy(How = How.Id, Using = "//input[@id='contact-email']")]
        private IWebElement _emailFld;

        [FindsBy(How = How.Id, Using = "confirm")]
        private IWebElement _confirmCheckBox;

        [FindsBy(How = How.XPath, Using = "//button[@class='contact-submit']")]
        private IWebElement _submitBtn;

        [FindsBy(How = How.XPath, Using = "//p[@class='feedback']")]
        private IWebElement _contactConfirmMsg;

        public Contact(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        //Navigate URL
        public static Contact NavigateTo(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(TestBase.PageUri);
            return new Contact(driver);
        }

        public void SelectContact()
        {

            {
                _contactLink.Click();
            }
        }

        public void EnterMessage()
        {

            {
                _contactMsgFld.SendKeys("Test Message");
            }
        }

        public void EnterName()
        {

            {
                _nameFld.SendKeys("Test Name");
            }
        }

        public void EnterEmail()
        {

            {
                String email = RandomString(10);
                _emailFld.SendKeys(email + "@yopmail.com");
            }
        }

        public void ConfirmCheckBox()
        {

            {
                _confirmCheckBox.Click();
            }
        }

        public void SubmitContactForm()
        {

            {
                _submitBtn.Click();
            }
        }

        public string ContactConfirmMsg()
        {

            {
                var _contactConfirmMsg = this._contactConfirmMsg.Text;
                return _contactConfirmMsg;
            }
        }

        public Random random = new Random();
        public string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}