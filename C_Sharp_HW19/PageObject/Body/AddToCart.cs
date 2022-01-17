using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

// Sheremet
namespace C_Sharp_HW19.PageObjects
{
    public class AddToCart : Body
    {
        public AddToCart(IWebDriver driver)
        {
            _driver = driver;
        }

        private readonly By _clickLinkToCart = By.XPath("(//div[@id='layer_cart']/div/div[2]/div[4]/a/span");
        private readonly By _clickLinkBackToBuy = By.XPath("(//div[@id='layer_cart']/div/div[2]/div[4]/span/span");


        public AddToCart ContinueShopping()
        {
            _driver.FindElement(_clickLinkToCart).SendKeys("123456789");
            return this;
        }

        public Cart GoToCart()
        {
            _driver.FindElement(_clickLinkBackToBuy).SendKeys("123456789");
            return new Cart(_driver);
        }

    }

    
}