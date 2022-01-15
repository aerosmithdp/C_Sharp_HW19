using OpenQA.Selenium;
using System;


namespace C_Sharp_HW19.PageObjects

{
    public class Cart : Header
    {
        public Cart(IWebDriver driver)
        {
            _driver = driver;
        }

    }
}
