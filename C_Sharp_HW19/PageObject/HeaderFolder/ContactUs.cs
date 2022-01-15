using OpenQA.Selenium;
using System;


namespace C_Sharp_HW19.PageObjects

{
    public class ContactUs : Header
    {
        public ContactUs(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
