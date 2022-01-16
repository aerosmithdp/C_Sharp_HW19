using OpenQA.Selenium;
using System;


namespace C_Sharp_HW19.PageObjects

{
    public class PersonalInfo : Header
    {
        public PersonalInfo(IWebDriver driver)
        {
            _driver = driver;
        }

    }
}
