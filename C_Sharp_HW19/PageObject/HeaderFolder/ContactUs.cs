using OpenQA.Selenium;
using System;

namespace C_Sharp_HW19.PageObject.HeaderFolder
{
    public class ContactUs : Header
    {
        public ContactUs(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
