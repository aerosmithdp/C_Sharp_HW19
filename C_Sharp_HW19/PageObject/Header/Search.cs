using OpenQA.Selenium;
using System;

namespace C_Sharp_HW19.PageObject
{
    public class Search : Header
    {
        public Search(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
