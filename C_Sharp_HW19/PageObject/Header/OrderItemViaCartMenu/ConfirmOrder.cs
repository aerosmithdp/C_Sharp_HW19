using System;
using OpenQA.Selenium;

//Sheremet
namespace C_Sharp_HW19.PageObjects
{
    public class ConfirmOrder : Header
    {
        public ConfirmOrder(IWebDriver driver)
        {
            _driver = driver;
        }

        private readonly By _submitOrderButton = By.XPath("//a[contains(text(),'Back to orders')]");

        public OrderHistory GoToOrderHistoryClick()
        {
            _driver.FindElement(_submitOrderButton).Click();
            return new OrderHistory(_driver);
        }

    }
}
