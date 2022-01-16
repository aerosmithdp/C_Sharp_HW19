using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace C_Sharp_HW19.PageObjects
{
    public class PrintedSummerDress2 : Body
    {
        public PrintedSummerDress2(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
