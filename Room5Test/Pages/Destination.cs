using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Room5Test.Pages
{
    public class Destination
    {
        private readonly IWebDriver _driver;

        [FindsBy(How = How.XPath, Using = "//div[@class='nav-icon']")]
        private IWebElement _destinationNavIcon;

        [FindsBy(How = How.XPath, Using = "//div[@class='destination-menu'][contains(text(),'West')]")]
        private IWebElement _destinationWest;

        [FindsBy(How = How.XPath, Using = "//div[@class='destination-page-post-section']//section[1]//div[1]//div[1]//a[1]")]
        private IWebElement _destinationArticalTile;

        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'Vegas Pool Parties: The Five Best Parties to Hit U')]")]
        private IWebElement _destinationConfirmHeader;

        public Destination(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        //Navigate URL
        public static Destination NavigateTo(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(TestBase.PageUri);
            return new Destination(driver);
        }


        public void DestinationNavIcon()
        {
            {
                _destinationNavIcon.Click();
            }
        }

        public void DestinationWest()
        {
            {
                _destinationWest.Click();
            }
        }

        public void DestinationArticalTile()
        {
            {
                _destinationArticalTile.Click();
            }
        }

        public string DestinationConfirmHeader()
        {
            {
                var _destinationConfirmHeader = this._destinationConfirmHeader.Text;
                return _destinationConfirmHeader;
            }
        }
    }
}
