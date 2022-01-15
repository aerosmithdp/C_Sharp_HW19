using System;
using OpenQA.Selenium;

namespace C_Sharp_HW19.PageObjects
{
    public class CasualDresses : Header
    {
        public CasualDresses(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
