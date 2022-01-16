using System;
using OpenQA.Selenium;

namespace C_Sharp_HW19.PageObjects
{
    public class SummerDresses : Header
    {
        public SummerDresses(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
