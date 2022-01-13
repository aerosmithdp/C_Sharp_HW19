using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace PracticeSelenium13012022.PageObject
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
        private By _womenHover = By.XPath("//div[@id='block_top_menu']/ul/li/a");
        private By _womenHoverTop = By.XPath("//a[contains(text(),'Tops')]");
        private By _womenHoverTshirts = By.XPath("");
        private By _womenHoverBlouses = By.XPath("");
        private By _womenHoverDresses = By.XPath("");
        private By _womenHoverCasualDresses = By.XPath("");
        private By _womenHoverEveningDresses = By.XPath("");
        private By _womenHoverSummerDresses = By.XPath("");



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

        public WomenHover ClickWomenHover()
        {
            _driver.FindElement(_womenHover).Click();
            return new WomenHover(_driver);
        }

        public WomenHover WomenHoverClickTops()
        {
            Actions actions = new(_driver);
            IWebElement element = _driver.FindElement(_womenHover);
            actions.MoveToElement(element).Perform();
            _driver.FindElement(_womenHoverTop).Click();
            return new WomenHover(_driver);

        }




    }
}
