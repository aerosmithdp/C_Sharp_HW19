using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace C_Sharp_HW19.PageObjects
{
    public class BannerExcepteur2 : Body
    {
        public BannerExcepteur2(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
