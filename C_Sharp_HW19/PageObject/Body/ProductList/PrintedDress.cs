using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace C_Sharp_HW19.PageObjects
{
    public class PrintedDress : Body
    {
        public PrintedDress(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
