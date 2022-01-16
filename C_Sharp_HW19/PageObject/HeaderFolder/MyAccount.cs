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

        private readonly By _orderHistoryBtn = By.XPath("//div[@id='center_column']/div/div/ul/li/a/span");
        private readonly By _credirSlipsBtn = By.XPath("//div[@id='center_column']/div/div/ul/li[2]/a/span");
        private readonly By _myAddressesBtn = By.XPath("//div[@id='center_column']/div/div/ul/li[3]/a/span");
        private readonly By _myPersonalInfoBtn = By.XPath("//div[@id='center_column']/div/div/ul/li[4]/a/span");
        private readonly By _myWishListBtn = By.XPath("//div[@id='center_column']/div/div[2]/ul/li/a/span");
    }
}