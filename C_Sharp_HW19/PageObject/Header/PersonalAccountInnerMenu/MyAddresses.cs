using OpenQA.Selenium;
using System;

//Sheremet

namespace C_Sharp_HW19.PageObjects

{
    public class MyAddresses : Header
    {
        public MyAddresses(IWebDriver driver)
        {
            _driver = driver;
        }

        private readonly By _goBackToMainMenu = By.XPath("//div[@id='center_column']/ul/li/a/span");
        private readonly By _goBackToAccountMenu = By.XPath("//div[@id='center_column']/ul/li[2]/a/span");
        private readonly By _updateInformation = By.XPath("//div[@id='center_column']/div/div/div/ul/li[9]/a/span");
        private readonly By _deleteInformation = By.XPath("//div[@id='center_column']/div/div/div/ul/li[9]/a[2]/span");
        private readonly By _addInformation = By.XPath("//div[@id='center_column']/div[2]/a/span");


        public HomePage GoBackToMainMenuFromAccount()
        {
            _driver.FindElement(_goBackToMainMenu).Click();
            return new HomePage(_driver);
        }

        public MyAccount GoBackToAccountMenuFromOrderHistoryPage()
        {
            _driver.FindElement(_goBackToAccountMenu).Click();
            return new MyAccount(_driver);
        }

        public ImproveAddresses UpdateInformation()
        {
            _driver.FindElement(_updateInformation).Click();
            return new ImproveAddresses(_driver);
        }

        public MyAddresses DeleteInformation()
        {
            _driver.FindElement(_deleteInformation).Click();
            _driver.FindElement(_deleteInformation).SendKeys(Keys.Escape);
            return this;
        }

        public ImproveAddresses AddMoreInformation()
        {
            _driver.FindElement(_addInformation).Click();
            return new ImproveAddresses(_driver);
        }
    }
}
