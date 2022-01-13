using System;
using OpenQA.Selenium;

namespace PracticeSelenium13012022.PageObject
{
    public class HomePage : Header
    {
        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
