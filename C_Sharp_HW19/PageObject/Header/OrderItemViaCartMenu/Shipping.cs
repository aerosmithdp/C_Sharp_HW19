using System;
using OpenQA.Selenium;

//Sheremet
namespace C_Sharp_HW19.PageObjects
{
    public class Shipping : Header
    {
        public Shipping(IWebDriver driver)
        {
            _driver = driver;
        }

        private readonly By _procedeToCheckout = By.XPath("//div[@id='center_column']/p[2]/a/span");
        private readonly By _continueShopping = By.XPath("//div[@id='center_column']/p[2]/a[2]");

        public Shipping KeepOrdering()
        {
            _driver.FindElement(_procedeToCheckout).Click();
            return new Shipping(_driver);
        }

        public HomePage ReturnToMainMenu()
        {
            _driver.FindElement(_continueShopping).Click();
            return new HomePage(_driver);
        }
    }
}