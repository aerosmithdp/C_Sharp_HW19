using System;
using OpenQA.Selenium;

namespace C_Sharp_HW19.PageObjects
{
    public class HomePage : Header
    {
        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
