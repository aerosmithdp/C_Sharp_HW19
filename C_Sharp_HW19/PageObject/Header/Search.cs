using OpenQA.Selenium;
using System;

//Created by Oleg Khizhnyi
namespace C_Sharp_HW19.PageObjects
{ 
    public class Search : Header
    {
        public Search(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
