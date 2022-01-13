using OpenQA.Selenium;
using System;

namespace PracticeSelenium13012022.PageObject
{
    public class WomenHover : Header
    {
        public WomenHover(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
