using System;
using OpenQA.Selenium;

//Sheremet
namespace C_Sharp_HW19.PageObjects
{
    public class Payment : Header
    {
        public Payment(IWebDriver driver)
        {
            _driver = driver;
        }

        private readonly By _goBackSummary = By.XPath("//ul[@id='order_step']/li/a");
        private readonly By _goBackAddresses = By.XPath("//ul[@id='order_step']/li[3]/a");
        private readonly By _goBackShipping = By.XPath("//ul[@id='order_step']/li[4]/a");
        private readonly By _continueShopping = By.XPath("//div[@id='center_column']/p[2]/a[2]");
        private readonly By _payByBankWire = By.XPath("//div[@id='HOOK_PAYMENT']/div/div/p/a");
        private readonly By _payByCheck = By.XPath("//div[@id='HOOK_PAYMENT']/div[2]/div/p/a");
        

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

        public PayBankWire PayViaBank()
        {
            _driver.FindElement(_payByBankWire).Click();
            return new PayBankWire(_driver);
        }

        public PayCheck PayViaCheck()
        {
            _driver.FindElement(_payByCheck).Click();
            return new PayCheck(_driver);
        }

        public HomePage ReturnToMainMenu()
        {
            _driver.FindElement(_continueShopping).Click();
            return new HomePage(_driver);
        }
    }
}

