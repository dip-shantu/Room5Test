using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using Xunit;

namespace Room5Test
{
    [Binding]
    public class TestBase
    {
        public static string PageUri = @"http://room5.trivago.com/";

    }
   
}
