using OpenQA.Selenium;
using System;

namespace PracticeSelenium13012022.PageObject
{
    public class Cart : Header
    {
        public Cart(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
