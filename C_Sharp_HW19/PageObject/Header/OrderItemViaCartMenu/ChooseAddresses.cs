using OpenQA.Selenium;
using System;

//Sheremet
namespace C_Sharp_HW19.PageObjects
{
    public class ChooseAddresses : Header
    {
        public ChooseAddresses(IWebDriver driver)
        {
            _driver = driver;
        }

        private readonly By _goBackSummary = By.XPath("//ul[@id='order_step']/li/a");
        private readonly By _chooseDeliveryAddress = By.XPath("//select[@id='id_address_delivery']");
        private readonly By _useBillingAsAddress = By.XPath("//input[@id='addressesAreEquals']");
        private readonly By _updateDeliveryAddress = By.XPath("//ul[@id='address_delivery']/li[9]/a/span");
        private readonly By _updateBillingAddress = By.XPath("//ul[@id='address_invoice']/li[9]/a/span");
        private readonly By _addNewAddress = By.XPath("//div[@id='center_column']/form/div/p/a/span");
        private readonly By _messageField = By.XPath("//input[@id='addressesAreEquals']");
        private readonly By _procedeToCheckout = By.XPath("//div[@id='center_column']/p[2]/a/span");
        private readonly By _continueShopping = By.XPath("//div[@id='center_column']/p[2]/a[2]");
        

        public Cart ReturnToSummary()
        {
            _driver.FindElement(_goBackSummary).Click();
            return new Cart(_driver);
        }

        public ChooseAddresses ChooseDeliveryAdress()
        {
            _driver.FindElement(_chooseDeliveryAddress).Click();
            _driver.FindElement(_chooseDeliveryAddress).SendKeys("mas");
            _driver.FindElement(_chooseDeliveryAddress).SendKeys(Keys.Enter);
            return this;
        }

        public ChooseAddresses ClickCheckboxBilling()
        {
            _driver.FindElement(_useBillingAsAddress).Click();
            return this;
        }

        public ImproveAddresses UpdateDeliveryAddress()
        {
            _driver.FindElement(_updateDeliveryAddress).Click();
            return new ImproveAddresses(_driver);
        }

        public ImproveAddresses UpdateBillingAddress()
        {
            _driver.FindElement(_updateBillingAddress).Click();
            return new ImproveAddresses(_driver);
        }

        public ChooseAddresses MessageField()
        {
            _driver.FindElement(_messageField).SendKeys("Hello");
            return this;
        }

        public ImproveAddresses AddNewAddress()
        {
            _driver.FindElement(_addNewAddress).Click();
            return new ImproveAddresses(_driver);
        }

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

