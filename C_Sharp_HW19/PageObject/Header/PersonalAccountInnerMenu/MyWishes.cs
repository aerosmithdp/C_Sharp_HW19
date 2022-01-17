using OpenQA.Selenium;
using System;

//Sheremet

namespace C_Sharp_HW19.PageObjects

{
    public class MyWishes : Header
    {
        public MyWishes(IWebDriver driver)
        {
            _driver = driver;
        }

        private readonly By _goBackToMainMenu = By.XPath("//div[@id='mywishlist']/ul/li[2]/a/span");
        private readonly By _goBackToAccountMenu = By.XPath("//div[@id='mywishlist']/ul/li/a/span");
        private readonly By _fieldInput = By.XPath("//input[@id='name']");
        private readonly By _submitWishList = By.XPath("//button[@id='submitWishlist']/span");
        private readonly By _deleteWish = By.XPath("//tr[@id='wishlist_42995']/td[6]/a/i");

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

        public MyWishes FieldInputWish()
        {
            _driver.FindElement(_fieldInput).SendKeys("Faded");
            return this;
        }

        public MyWishes SubmitWishClick()
        {
            _driver.FindElement(_submitWishList).Click();
            return this;
        }

        public MyWishes DeleteWishClick()
        {
            _driver.FindElement(_deleteWish).Click();
            return this;
        }
    }
}
