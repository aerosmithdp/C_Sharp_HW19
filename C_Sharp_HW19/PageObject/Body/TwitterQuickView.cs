using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

// Natali nikulina

namespace C_Sharp_HW19.PageObjects
{
    public class TwitterQuickView : Body
    {
        public TwitterQuickView(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
