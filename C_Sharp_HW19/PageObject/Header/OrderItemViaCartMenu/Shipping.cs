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

        private readonly By _goBackSummary = By.XPath("//ul[@id='order_step']/li/a");
        private readonly By _goBackAddresses = By.XPath("//ul[@id='order_step']/li[3]/a");
        private readonly By _procedeToCheckout = By.XPath("//form[@id='form']/p/button/span");
        private readonly By _continueShopping = By.XPath("//div[@id='center_column']/p[2]/a[2]");
        private readonly By _agreeWithTerms = By.XPath("//div[@id='uniform-cgv']/span/input");
        private readonly By _termsOfService = By.XPath("//a[contains(text(),'(Read the Terms of Service)')]");
        private readonly By _closeWarningWindow = By.XPath("//a[contains(@href, 'javascript:;')]");



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

        public Shipping KeepOrderingFirstTry()
        {
            _driver.FindElement(_procedeToCheckout).Click();
            return new Shipping(_driver);
        }

        public Shipping CloseWarningWindow()
        {
            _driver.FindElement(_closeWarningWindow).Click();
            return new Shipping(_driver);
        }

        public Shipping AgreeWithTerms()
        {
            _driver.FindElement(_agreeWithTerms).Click();
            return this;
        }

        public Shipping Terms()
        {
            _driver.FindElement(_termsOfService).Click();
            return this;
        }

        public Payment KeepOrderingSecondTry()
        {
            _driver.FindElement(_procedeToCheckout).Click();
            return new Payment(_driver);
        }
        public HomePage ReturnToMainMenu()
        {
            _driver.FindElement(_continueShopping).Click();
            return new HomePage(_driver);
        }
    }
}