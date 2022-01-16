using System;
using OpenQA.Selenium;

namespace C_Sharp_HW19.PageObjects
{
    public class EveningDresses : Header
    {
        public EveningDresses(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
