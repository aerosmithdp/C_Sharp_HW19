using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace C_Sharp_HW19.PageObjects
{
    public class BannerSunGlasses:Body
    {
        public BannerSunGlasses(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
