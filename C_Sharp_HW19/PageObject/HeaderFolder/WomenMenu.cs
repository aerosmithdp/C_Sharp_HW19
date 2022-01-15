using OpenQA.Selenium;
using System;


namespace C_Sharp_HW19.PageObjects
{
    public class WomenMenu : Header
    {
        public WomenMenu(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
