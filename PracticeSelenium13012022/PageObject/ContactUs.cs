using OpenQA.Selenium;
using System;

namespace PracticeSelenium13012022.PageObject
{
    public class ContactUs: Header
    {
        public ContactUs(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
