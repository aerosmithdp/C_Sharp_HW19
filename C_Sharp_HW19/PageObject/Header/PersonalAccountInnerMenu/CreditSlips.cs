using OpenQA.Selenium;
using System;


//Sheremet


namespace C_Sharp_HW19.PageObjects

{
    public class CreditSlips : Header
    {
        public CreditSlips(IWebDriver driver)
        {
            _driver = driver;
        }

        private readonly By _goBackToMainMenu = By.XPath("//div[@id='center_column']/ul/li/a/span");
        private readonly By _goBackToAccountMenu = By.XPath("//div[@id='center_column']/ul/li[2]/a/span");


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
    }
}
