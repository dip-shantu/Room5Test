using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using Xunit;
using OpenQA.Selenium.Support.PageObjects;
using System.Linq;

namespace Room5Test.Pages
{
    public class Contact
    {
        public readonly IWebDriver _driver;

        [FindsBy(How = How.XPath, Using = "//*[@id='footer - main']/div[1]/div[2]/div/div[2]/a")]
        private IWebElement _contactLink;

        [FindsBy(How = How.XPath, Using = "//textarea[contains(@class,'contact-msg')]")]
        private IWebElement _contactMsgFld;

        [FindsBy(How = How.XPath, Using = "(//input[@class='contact-input'])[1]")]
        private IWebElement _nameFld;

        [FindsBy(How = How.Id, Using = "contact-email")]
        private IWebElement _emailFld;

        [FindsBy(How = How.Id, Using = "confirm")]
        private IWebElement _confirmCheckBox;

        [FindsBy(How = How.XPath, Using = "//button[@class='contact-submit']")]
        private IWebElement _submitBtn;

        public Contact(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
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
                _emailFld.SendKeys("'RandomString' + @yopmail.com");
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

        public static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
