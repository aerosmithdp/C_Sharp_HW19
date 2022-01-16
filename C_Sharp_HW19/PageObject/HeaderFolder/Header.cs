using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

//Created by Oleg Khizhnyi, Natali Nikulina, Viacheslav Sheremet at a lecture
//Edited and supplemented by Oleg Khizhnyi


namespace C_Sharp_HW19.PageObjects

{
    public class Header
    {
        protected IWebDriver _driver;

        private readonly By _banner = By.XPath("//header[@id='header']/div/div/div/a/img");
        private readonly By _contactUs = By.XPath("//a[contains(text(),'Contact us')]");
        private readonly By _signIn = By.XPath("//a[contains(text(),'Sign in')]");
        private readonly By _logo = By.XPath("//div[@id='header_logo']/a/img");
        private readonly By _search = By.XPath("//input[@id='search_query_top']");
        private readonly By _searchButton = By.XPath("//button[@name='submit_search']");
        private readonly By _cart = By.XPath("//header[@id='header']/div[3]/div/div/div[3]/div/a/span[5]");
        private readonly By _womenMenu = By.XPath("//div[@id='block_top_menu']/ul/li/a");
        private readonly By _womenMenuTops = By.XPath("//a[contains(text(),'Tops')]");
        private readonly By _womenMenuTshirts = By.XPath("//a[contains(.,'T-shirts')]");
        private readonly By _womenMenuBlouses = By.CssSelector(".sfHover:nth-child(2) > a");
        private readonly By _womenMenuDresses = By.XPath("//a[contains(text(),'Dresses')]");
        private readonly By _womenMenuCasualDresses = By.XPath("//a[contains(text(),'Casual Dresses')]");
        private readonly By _womenMenuEveningDresses = By.XPath("//a[contains(text(),'Evening Dresses')]");
        private readonly By _womenMenuSummerDresses = By.XPath("//a[contains(text(),'Summer Dresses')]");
        private readonly By _dressesMenu = By.XPath("(//a[contains(text(),'Dresses')])[5]");
        private readonly By _dressesMenuCasualDresses = By.XPath("xpath=(//a[contains(text(),'Casual Dresses')])[2]");
        private readonly By _dressesMenuEveningDresses = By.XPath("xpath=(//a[contains(text(),'Evening Dresses')])[2]");
        private readonly By _dressesMenuSummerDresses = By.XPath("xpath=(//a[contains(text(),'Summer Dresses')])[2]");
        private readonly By _tshirtsButton = By.XPath("(//a[contains(text(),'T-shirts')])[2]");


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
        public Header DropDownWomenMenu()
        {
            Actions actions = new(_driver);
            IWebElement element = _driver.FindElement(_womenMenu);
            actions.MoveToElement(element).Perform();
            return this;
        }
        public WomenPage ClickWomenMenu()
        {
            _driver.FindElement(_womenMenu).Click();
            return new WomenPage(_driver);
        }
        public Tops DropDownWomenMenuClickTops()
        {
            Actions actions = new(_driver);
            IWebElement element = _driver.FindElement(_womenMenu);
            actions.MoveToElement(element).Perform();
            _driver.FindElement(_womenMenuTops).Click();
            return new Tops(_driver);
        }
        public Tshirts DropDownWomenMenuClickTshirts()
        {
            Actions actions = new(_driver);
            IWebElement element = _driver.FindElement(_womenMenu);
            actions.MoveToElement(element).Perform();
            _driver.FindElement(_womenMenuTshirts).Click();
            return new Tshirts(_driver);
        }
        public Blouses DropDownWomenMenuClickBlouses()
        {
            Actions actions = new(_driver);
            IWebElement element = _driver.FindElement(_womenMenu);
            actions.MoveToElement(element).Perform();
            _driver.FindElement(_womenMenuBlouses).Click();
            return new Blouses(_driver);
        }
        public Dresses DropDownWomenMenuClickDresses()
        {
            Actions actions = new(_driver);
            IWebElement element = _driver.FindElement(_womenMenu);
            actions.MoveToElement(element).Perform();
            _driver.FindElement(_womenMenuDresses).Click();
            return new Dresses(_driver);
        }
        public CasualDresses DropDownWomenMenuClickCasualDresses()
        {
            Actions actions = new(_driver);
            IWebElement element = _driver.FindElement(_womenMenu);
            actions.MoveToElement(element).Perform();
            _driver.FindElement(_womenMenuCasualDresses).Click();
            return new CasualDresses(_driver);
        }
        public EveningDresses DropDownWomenMenuClickEveningDresses()
        {
            Actions actions = new(_driver);
            IWebElement element = _driver.FindElement(_womenMenu);
            actions.MoveToElement(element).Perform();
            _driver.FindElement(_womenMenuEveningDresses).Click();
            return new EveningDresses(_driver);
        }
        public SummerDresses DropDownWomenMenuClickSummerDresses()
        {
            Actions actions = new(_driver);
            IWebElement element = _driver.FindElement(_womenMenu);
            actions.MoveToElement(element).Perform();
            _driver.FindElement(_womenMenuSummerDresses).Click();
            return new SummerDresses(_driver);
        }
        public Header DropDownDressesMenu()
        {
            Actions actions = new(_driver);
            IWebElement element = _driver.FindElement(_dressesMenu);
            actions.MoveToElement(element).Perform();
            return this;
        }
        public Dresses ClickDressesMenu()
        {
            _driver.FindElement(_dressesMenu).Click();
            return new Dresses(_driver);
        }
        public CasualDresses DropDownDressesMenuClickCasualDresses()
        {
            Actions actions = new(_driver);
            IWebElement element = _driver.FindElement(_dressesMenu);
            actions.MoveToElement(element).Perform();
            _driver.FindElement(_dressesMenuCasualDresses).Click();
            return new CasualDresses(_driver);
        }
        public EveningDresses DropDownDressesMenuClickEveningDresses()
        {
            Actions actions = new(_driver);
            IWebElement element = _driver.FindElement(_dressesMenu);
            actions.MoveToElement(element).Perform();
            _driver.FindElement(_dressesMenuEveningDresses).Click();
            return new EveningDresses(_driver);
        }
        public SummerDresses DropDownDressesMenuClickSummerDresses()
        {
            Actions actions = new(_driver);
            IWebElement element = _driver.FindElement(_dressesMenu);
            actions.MoveToElement(element).Perform();
            _driver.FindElement(_dressesMenuSummerDresses).Click();
            return new SummerDresses(_driver);
        }
        public Tshirts ClickTshirtsButton()
        {
            _driver.FindElement(_tshirtsButton).Click();
            return new Tshirts(_driver);
        }

        

    }
}
