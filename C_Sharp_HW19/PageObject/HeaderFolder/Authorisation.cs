using OpenQA.Selenium;
using System;


namespace C_Sharp_HW19.PageObjects

{
    public class Authorisation : Header
    {
        public Authorisation(IWebDriver driver)
        {
            _driver = driver;
        }

    }
}