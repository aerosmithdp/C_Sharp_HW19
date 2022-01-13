using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PracticeSelenium13012022
{
    public class BaseTest : IDisposable
    {
         IWebDriver _driver;

        public void Dispose()
        {
            //_driver.Quit();
        }

        public IWebDriver StartDriverOnPage(string url)
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            _driver.Navigate().GoToUrl(url);
            _driver.Manage().Window.Maximize();
            return _driver;
        }

    }

}
