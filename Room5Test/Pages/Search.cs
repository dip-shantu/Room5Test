using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using Xunit;
using OpenQA.Selenium.Support.PageObjects;

namespace Room5Test.Pages
{
    public class Search : TestBase
    {
        private readonly IWebDriver _driver;
        //private const string PageUri = @"http://room5.trivago.com/";

        [FindsBy (How = How.XPath, Using = "/html/body/div[1]/div[1]/header/div/div/div[2]")]
        private IWebElement _searchIcon;

        [FindsBy(How = How.XPath, Using = "//*[@id='search']/div[1]/div[4]/div/div[1]/div[2]/div/div/div")]
        private IWebElement _destinationCanada;

        [FindsBy(How = How.XPath, Using = "//*[@id='search']/div[1]/div[6]/div/div[1]/div[2]/div/div/div")]
        private IWebElement _tagsBudget;

        [FindsBy(How = How.XPath, Using = "//*[@id='search']/div[1]/div[8]/section/div/div/a/span[2]/span[1]")]
        private IWebElement _searchResult;



        public Search(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        //Navigate URL
        public static Search NavigateTo(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(TestBase.PageUri);
            return new Search(driver);
        }

        public void SearchIcon()
        {
            
            {
                _searchIcon.Click();
            }
        }

        public void DestinationCanada()
        {
            
            {
                _destinationCanada.Click();
            }
        }

        public void TagsBudget()
        {
            {
                _tagsBudget.Click();
            }
        }

        public string SearchResult()
        {
            {
                var _searchResult = this._searchResult.Text;
                return _searchResult;
            }
        }
    }
}
