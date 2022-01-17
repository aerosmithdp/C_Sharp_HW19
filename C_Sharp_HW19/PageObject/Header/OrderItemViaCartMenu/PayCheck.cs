using System;
using OpenQA.Selenium;

//Sheremet
namespace C_Sharp_HW19.PageObjects
{
    public class PayCheck : Header
    {
        public PayCheck(IWebDriver driver)
        {
            _driver = driver;
        }

        private readonly By _goBackSummary = By.XPath("//ul[@id='order_step']/li/a");
        private readonly By _goBackAddresses = By.XPath("//ul[@id='order_step']/li[3]/a");
        private readonly By _goBackShipping = By.XPath("//ul[@id='order_step']/li[4]/a");
        private readonly By _goBackPayment = By.XPath("//p[@id='cart_navigation']/a");
        private readonly By _submitOrderButton = By.XPath("//p[@id='cart_navigation']/a");

        public Cart ReturnToSummary()
        {
            _driver.FindElement(_goBackSummary).Click();
            return new Cart(_driver);
        }

        public ChooseAddresses ReturnToAddresses()
        {
            _driver.FindElement(_goBackAddresses).Click();
            return new ChooseAddresses(_driver);
        }

        public Shipping ReturnToShipping()
        {
            _driver.FindElement(_goBackShipping).Click();
            return new Shipping(_driver);
        }

        public Payment ReturnToPayment()
        {
            _driver.FindElement(_goBackPayment).Click();
            return new Payment(_driver);
        }

        public ConfirmOrder SubmitOrderClick()
        {
            _driver.FindElement(_submitOrderButton).Click();
            return new ConfirmOrder(_driver);
        }


    }
}
