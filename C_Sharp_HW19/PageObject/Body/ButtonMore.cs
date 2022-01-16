using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace C_Sharp_HW19.PageObjects
{
    public class ButtonMore : Body
    {
        public ButtonMore(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
