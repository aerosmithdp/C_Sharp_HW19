using OpenQA.Selenium;
using System;

namespace C_Sharp_HW19.PageObjects
{
    public class WomenPage : Header
    {
        public WomenPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}