using System;
using OpenQA.Selenium;
using C_Sharp_HW19.PageObject.HeaderFolder;

namespace C_Sharp_HW19.PageObject
{
    public class HomePage : Header
    {
        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
