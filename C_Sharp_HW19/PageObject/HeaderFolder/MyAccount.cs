using OpenQA.Selenium;
using System;


namespace C_Sharp_HW19.PageObjects

{
    public class MyAccount : Header
    {
        public MyAccount(IWebDriver driver)
        {
            _driver = driver;
        }

        private readonly By _orderHistory = By.XPath("//div[@id='center_column']/div/div/ul/li/a/span");
        private readonly By _credirSlips = By.XPath("//div[@id='center_column']/div/div/ul/li[2]/a/span");
        private readonly By _myAddresses =  By.XPath("//div[@id='center_column']/div/div/ul/li[4]/a/span");
        private readonly By _myWishList = By.XPath("//div[@id='center_column']/div/div[2]/ul/li/a/span");
        private readonly By _myPersonalInformation = By.XPath("//div[@id='center_column']/div/div/ul/li[4]/a/span");

        private readonly By _goBackToMainMenu = By.XPath("//div[@id='center_column']/ul/li/a/span");

        public OrderHistory ClickOrderHistoryInsideAccount()
        {
            _driver.FindElement(_orderHistory).Click();
            return new OrderHistory(_driver);
        }

        public CreditSlips ClickCreditSlipsInsideAccount()
        {
            _driver.FindElement(_credirSlips).Click();
            return new CreditSlips(_driver);
        }

        public MyAddresses ClickMyAddressesInsideAccount()
        {
            _driver.FindElement(_myAddresses).Click();
            return new MyAddresses(_driver);
        }

        public MyPersonalInformation ClickPersonalInfoInsideAccount()
        {
            _driver.FindElement(_myPersonalInformation).Click();
            return new MyPersonalInformation(_driver);
        }

        public MyWishes ClickMyWishListInsideAccount()
        {
            _driver.FindElement(_myWishList).Click();
            return new MyWishes(_driver);
        }

        public HomePage GoBackToMainMenuFromAccount()
        {
            _driver.FindElement(_goBackToMainMenu).Click();
            return new HomePage(_driver);
        }
    }
}