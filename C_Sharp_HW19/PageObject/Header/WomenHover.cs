using OpenQA.Selenium;
using System;

namespace C_Sharp_HW19.PageObject
{
    public class WomenHover : Header
    {
        public WomenHover(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
