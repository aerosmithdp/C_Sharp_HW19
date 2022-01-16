using OpenQA.Selenium;
using System;


namespace C_Sharp_HW19.PageObjects
{
    public class MyAccount : Header
    {
        public MyAccount(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}