using OpenQA.Selenium;
using System;


namespace C_Sharp_HW19.PageObjects

{
    public class OrderHistory : Header
    {
        public OrderHistory(IWebDriver driver)
        {
            _driver = driver;
        }

    }
}
