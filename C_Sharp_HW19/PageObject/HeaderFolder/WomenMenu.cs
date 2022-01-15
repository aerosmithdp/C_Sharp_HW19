using OpenQA.Selenium;
using System;


namespace C_Sharp_HW19.PageObject
{
    public class WomenMenu : Header
    {
        public WomenMenu(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
