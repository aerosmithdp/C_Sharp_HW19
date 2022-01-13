using OpenQA.Selenium;
using System;

namespace PracticeSelenium13012022.PageObject
{
    public class SignIn : Header
    {
        public SignIn(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
