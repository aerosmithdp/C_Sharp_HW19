using System;
using OpenQA.Selenium;

//Created by Oleg Khizhnyi
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
