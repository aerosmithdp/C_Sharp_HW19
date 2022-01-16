using OpenQA.Selenium;
using System;

//Created by Oleg Khizhnyi
namespace C_Sharp_HW19.PageObjects
{
    public class Cart : Header
    {
        public Cart(IWebDriver driver)
        {
            _driver = driver;
        }

    }
}
