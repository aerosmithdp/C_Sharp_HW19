using OpenQA.Selenium;
using System;

namespace PracticeSelenium13012022.PageObject
{
    public class Search : Header
    {
        public Search(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
