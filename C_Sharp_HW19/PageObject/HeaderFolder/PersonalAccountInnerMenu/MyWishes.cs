using OpenQA.Selenium;
using System;


namespace C_Sharp_HW19.PageObjects

{
    public class MyWishes : Header
    {
        public MyWishes(IWebDriver driver)
        {
            _driver = driver;
        }

    }
}
