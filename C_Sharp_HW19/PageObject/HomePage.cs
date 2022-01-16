using System;
using OpenQA.Selenium;

//Created by Oleg Khizhnyi
namespace C_Sharp_HW19.PageObjects
{
    public class HomePage : Header
    {
        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
