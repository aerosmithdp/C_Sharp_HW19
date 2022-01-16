using OpenQA.Selenium;
using System;


namespace C_Sharp_HW19.PageObjects

{
    public class CreditSlips : Header
    {
        public CreditSlips(IWebDriver driver)
        {
            _driver = driver;
        }

    }
}