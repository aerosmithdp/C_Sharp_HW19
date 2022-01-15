using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace C_Sharp_HW19.PageObjects
{
    public class Body
    {
        protected IWebDriver _driver;

        private By _bunnerStatic1 = By.Id("");
        private By _bunnerStatic2 = By.Id("");
        private By _bunnerStatic3 = By.Id("");
        private By _bunnerStatic4 = By.Id("");
        private By _bunnerStatic5 = By.Id("");
        private By _bunnerStatic6 = By.Id("");
        private By _bunnerStatic7 = By.Id("");

        private By _bunnerSlider1 = By.Id("");
        private By _bunnerSlider2 = By.Id("");
        private By _bunnerSlider3 = By.Id("");

        private By _popular = By.Id("");
        private By _bestSellers = By.Id("");
    }
}
