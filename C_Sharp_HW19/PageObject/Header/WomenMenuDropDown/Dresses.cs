using System;
using OpenQA.Selenium;

//Created by Oleg Khizhnyi
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
