using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace C_Sharp_HW19.PageObjects
{
    public class Body
    {
        protected IWebDriver _driver;

        private By _bannerSale = By.XPath("//img[contains(@src,'http://automationpractice.com/modules/themeconfigurator/img/banner-img6.jpg')]");
        private By _bannerOnlyOnline = By.XPath("//img[contains(@src,'http://automationpractice.com/modules/themeconfigurator/img/banner-img7.jpg')]");
        private By _bannerTopTrends = By.XPath("//img[contains(@src,'http://automationpractice.com/modules/themeconfigurator/img/banner-img1.jpg')]");
        private By _bannerMens = By.XPath("//img[contains(@src,'http://automationpractice.com/modules/themeconfigurator/img/banner-img2.jpg')]");
        private By _bannerWomens = By.XPath("//img[contains(@src,'http://automationpractice.com/modules/themeconfigurator/img/banner-img3.jpg')]");
        private By _bannerSunGlasses = By.XPath("//img[contains(@src,'http://automationpractice.com/modules/themeconfigurator/img/banner-img4.jpg')]");
        private By _bannerSavvyTrends = By.XPath("//img[contains(@src,'http://automationpractice.com/modules/themeconfigurator/img/banner-img5.jpg')]");

        private By _bannerExcepteur1 = By.XPath("//ul[@id='homeslider']/li[2]/div/p");
        private By _bannerExcepteur2 = By.XPath("//ul[@id='homeslider']/li[3]/div");
        private By _bannerExcepteur3 = By.XPath("//ul[@id='homeslider']/li[4]/div");
        private By _buttonShopNowExcepteur1 = By.XPath("(//button[@type='button'])[2]");
        private By _buttonShopNowExcepteur2 = By.XPath("(//button[@type='button'])[3]");
        private By _buttonShopNowExcepteur3 = By.XPath("(//button[@type='button'])[4]");

        private By _buttonPrev = By.XPath("//a[contains(text(),'Prev')]");
        private By _buttonNext = By.XPath("//a[contains(text(),'Next')]");

        private By _popular = By.XPath("//a[contains(text(),'Popular')]");
        private By _bestSellers = By.XPath("//a[contains(text(),'Best Sellers')]");

        private By _fadedShortSleeve = By.XPath("//img[@alt='Faded Short Sleeve T-shirts']");
        private By _blouse = By.XPath("//img[@alt='Blouse']");
        private By _printedDress = By.XPath("//img[@alt='Printed Dress']");
        private By _printedDress2 = By.XPath("(//img[@alt='Printed Dress'])[2]");
        private By _printedSummerDress = By.XPath("//img[@alt='Printed Summer Dress']");
        private By _printedSummerDress2 = By.XPath("(//img[@alt='Printed Summer Dress'])[2]");
        private By _printedChiffonDress = By.XPath("//img[@alt='Printed Chiffon Dress']");

        private By _addToCart = By.LinkText("Add to cart");
        private By _more = By.LinkText("More");
        private By _iconeEyeOpen = By.XPath("//span[contains(.,'Quick view')]");



        public PrestaShopPage ClickBannerSale()
        {
            _driver.FindElement(_bannerSale).Click();
            return new PrestaShopPage(_driver);
        }

        public PrestaShopPage ClickBannerOnlyOnline()
        {
            _driver.FindElement(_bannerOnlyOnline).Click();
            return new PrestaShopPage(_driver);
        }

        public PrestaShopPage ClickBannerTopTrends()
        {
            _driver.FindElement(_bannerTopTrends).Click();
            return new PrestaShopPage(_driver);
        }

        public PrestaShopPage ClickBannerMens()
        {
            _driver.FindElement(_bannerMens).Click();
            return new PrestaShopPage(_driver);
        }

        public PrestaShopPage ClickBannerWomens()
        {
            _driver.FindElement(_bannerWomens).Click();
            return new PrestaShopPage(_driver);
        }

        public PrestaShopPage ClickBannerSunGlasses()
        {
            _driver.FindElement(_bannerSunGlasses).Click();
            return new PrestaShopPage(_driver);
        }

        public PrestaShopPage ClickBannerSavvyTrends()
        {
            _driver.FindElement(_bannerSavvyTrends).Click();
            return new PrestaShopPage(_driver);
        }

        public Body ClickButtonPrev()
        {
            _driver.FindElement(_buttonPrev).Click();
            return this;
        }

        public Body ClickButtonNext()
        {
            _driver.FindElement(_buttonNext).Click();
            return this;
        }

        public PrestaShopPage ClickBannerExcepteur1()
        {
            _driver.FindElement(_bannerExcepteur1).Click();
            return new PrestaShopPage(_driver);
        }
        
        public PrestaShopPage ClickBannerExcepteur2()
        {
            _driver.FindElement(_buttonNext).Click();
            _driver.FindElement(_bannerExcepteur2).Click();
            return new PrestaShopPage(_driver);
        }
        
        public PrestaShopPage ClickBannerExcepteur3()
        {
            _driver.FindElement(_buttonNext).Click();
            _driver.FindElement(_buttonNext).Click();
            _driver.FindElement(_bannerExcepteur3).Click();
            return new PrestaShopPage(_driver);
        }
        
        public PrestaShopPage ClickButtonShopNowExcepteur1()
        {
            _driver.FindElement(_bannerExcepteur1);
            _driver.FindElement(_buttonShopNowExcepteur1).Click();
            return new PrestaShopPage(_driver);
        }
        
        public PrestaShopPage ClickButtonShopNowExcepteur2()
        {
            _driver.FindElement(_buttonNext).Click();
            _driver.FindElement(_buttonShopNowExcepteur2).Click();
            return new PrestaShopPage(_driver);
        }
        
        public PrestaShopPage ClickButtonShopNowExcepteur3()
        {
            _driver.FindElement(_buttonNext).Click();
            _driver.FindElement(_buttonNext).Click();
            _driver.FindElement(_buttonShopNowExcepteur3).Click();
            return new PrestaShopPage(_driver);
        }

        public Body ClickButtonPopular()
        {
            _driver.FindElement(_popular).Click();
            return this;
        }

        public Body ClickButtonBestSellers()
        {
            _driver.FindElement(_bestSellers).Click();
            return this;
        }

        public Blouse ClickBlouseSeeDescription()
        {
            _driver.FindElement(_blouse).Click();
            return new Blouse(_driver);
        }

        public PrintedChiffonDress ClickPrintedChiffonDressSeeDescription()
        {
            _driver.FindElement(_printedChiffonDress).Click();
            return new PrintedChiffonDress(_driver);
        }

        public PrintedDress ClickPrintedDressSeeDescription()
        {
            _driver.FindElement(_printedDress).Click();
            return new PrintedDress(_driver);
        }

        public PrintedDress2 ClickPrintedDress2SeeDescription()
        {
            _driver.FindElement(_printedDress2).Click();
            return new PrintedDress2(_driver);
        }

        public PrintedSummerDress ClickPrintedSummerDressSeeDescription()
        {
            _driver.FindElement(_printedSummerDress).Click();
            return new PrintedSummerDress(_driver);
        }

        public PrintedSummerDress2 ClickPrintedSummerDress2SeeDescription()
        {
            _driver.FindElement(_printedSummerDress2).Click();
            return new PrintedSummerDress2(_driver);
        }

        public ShortSleeve ClickShortSleeveSeeDescription()
        {
            _driver.FindElement(_fadedShortSleeve).Click();
            return new ShortSleeve(_driver);
        }

        public ButtonAddToCart ClickButtonAddToCart()
        {
            _driver.FindElement(_addToCart).Click();
            return new ButtonAddToCart(_driver);
        }

        public ButtonMore ClickButtonMore()
        {
            _driver.FindElement(_more).Click();
            return new ButtonMore(_driver);
        }

        public IconeEyeOpen ClickIconeEyeOpen()
        {
            _driver.FindElement(_iconeEyeOpen).Click();
            return new IconeEyeOpen(_driver);
        }


      


    }
}
