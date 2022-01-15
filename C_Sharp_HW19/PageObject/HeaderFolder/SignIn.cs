using OpenQA.Selenium;
using System;

namespace C_Sharp_HW19.PageObject.HeaderFolder
{
    public class SignIn : Header
    {
        public SignIn(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
