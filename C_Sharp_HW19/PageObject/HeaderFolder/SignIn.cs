using OpenQA.Selenium;
using System;


namespace C_Sharp_HW19.PageObjects
{

    public class SignIn : Header
    {
        public SignIn(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
