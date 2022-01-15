using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

//Created by Oleg Khizhnyi, Natali Nikulina, Viacheslav Sheremet

namespace C_Sharp_HW19.PageObject
{
    public class Header
    {
        protected IWebDriver _driver;

        private By _banner = By.XPath("//header[@id='header']/div/div/div/a/img");
        private By _contactUs = By.XPath("//a[contains(text(),'Contact us')]");
        private By _signIn = By.XPath("//a[contains(text(),'Sign in')]");
        private By _logo = By.XPath("//div[@id='header_logo']/a/img");
        private By _search = By.XPath("//input[@id='search_query_top']");
        private By _searchButton = By.XPath("//button[@name='submit_search']");
        private By _cart = By.XPath("//header[@id='header']/div[3]/div/div/div[3]/div/a/span[5]");
        private By _womenMenu = By.XPath("//div[@id='block_top_menu']/ul/li/a");
        private By _womenMenuTop = By.XPath("//a[contains(text(),'Tops')]");
        private By _womenMenuTshirts = By.XPath("//a[contains(.,'T-shirts')]");
        private By _womenMenuBlouses = By.CssSelector(".sfHover:nth-child(2) > a");
        private By _womenMenuDresses = By.XPath("//a[contains(text(),'Dresses')]");
        private By _womenMenuCasualDresses = By.XPath("//a[contains(text(),'Casual Dresses')]");
        private By _womenMenuEveningDresses = By.XPath("//a[contains(text(),'Evening Dresses')]");
        private By _womenMenuSummerDresses = By.XPath("//a[contains(text(),'Summer Dresses')]");



        public Header ClickBanner()
        {
            _driver.FindElement(_banner).Click();
            return this;
        }
        public ContactUs ClickContactUs()
        {
            _driver.FindElement(_contactUs).Click();
            return new ContactUs(_driver);
        }
        public SignIn ClickSignIn()
        {
            _driver.FindElement(_signIn).Click();
            return new SignIn(_driver);
        }
        public Header ClickLogo()
        {
            _driver.FindElement(_logo).Click();
            return this;
        }
        public Search ClickSearch()
        {
            _driver.FindElement(_search).Click();
            _driver.FindElement(_search).SendKeys("Summer dresses");
            _driver.FindElement(_search).SendKeys(Keys.Enter);
            return new Search(_driver);
        }

        public Search ClickSearchButton()
        {
            _driver.FindElement(_search).Click();
            _driver.FindElement(_search).SendKeys("Summer dresses");
            _driver.FindElement(_searchButton).Click();
            return new Search(_driver);
        }

        public Cart ClickCart()
        {
            _driver.FindElement(_cart).Click();
            return new Cart(_driver);
        }

        public WomenMenu ClickWomenMenu()
        {
            _driver.FindElement(_womenMenu).Click();
            return new WomenMenu(_driver);
        }

        public WomenMenu WomenMenuClickTops()
        {
            Actions actions = new(_driver);
            IWebElement element = _driver.FindElement(_womenMenu);
            actions.MoveToElement(element).Perform();
            _driver.FindElement(_womenMenuTop).Click();
            return new WomenMenu(_driver);

        }

        public WomenMenu WomenMenuClickTshirts()
        {
            Actions actions = new(_driver);
            IWebElement element = _driver.FindElement(_womenMenu);
            actions.MoveToElement(element).Perform();
            _driver.FindElement(_womenMenuTshirts).Click();
            return new WomenMenu(_driver);
        }

        public WomenMenu WomenMenuClickBlouses()
        {
            Actions actions = new(_driver);
            IWebElement element = _driver.FindElement(_womenMenu);
            actions.MoveToElement(element).Perform();
            _driver.FindElement(_womenMenuBlouses).Click();
            return new WomenMenu(_driver);
        }



    }
}
