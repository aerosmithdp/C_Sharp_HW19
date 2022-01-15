using System;
using OpenQA.Selenium;

namespace C_Sharp_HW19.PageObjects
{
    public class Dresses : Header
    {
        public Dresses(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
