using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

// Наталья Никулина

namespace C_Sharp_HW19.PageObjects
{
    public class Body 
    {
        protected IWebDriver _driver;
        //баннеры в body
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
        //кнопки в баннере
        private By _buttonShopNowExcepteur1 = By.XPath("//button[@type='button']");
        private By _buttonShopNowExcepteur2 = By.XPath("(//button[@type='button'])[3]");
        private By _buttonShopNowExcepteur3 = By.XPath("(//button[@type='button'])[4]");
        private By _buttonPrev = By.XPath("//a[contains(text(),'Prev')]");
        private By _buttonNext = By.XPath("//a[contains(text(),'Next')]");
        //фильтр товара
        private By _popular = By.XPath("//a[contains(text(),'Popular')]");
        private By _bestSellers = By.XPath("//a[contains(text(),'Best Sellers')]");
        //каталог товаров
        private By _fadedShortSleeve = By.XPath("//img[@alt='Faded Short Sleeve T-shirts']");
        private By _blouse = By.XPath("//img[@alt='Blouse']");
        private By _printedDress = By.XPath("//img[@alt='Printed Dress']");
        private By _printedDress2 = By.XPath("(//img[@alt='Printed Dress'])[2]");
        private By _printedSummerDress = By.XPath("//img[@alt='Printed Summer Dress']");
        private By _printedSummerDress2 = By.XPath("(//img[@alt='Printed Summer Dress'])[2]");
        private By _printedChiffonDress = By.XPath("//img[@alt='Printed Chiffon Dress']");
        //действия с товаром
        private By _addToCart = By.LinkText("Add to cart");
        private By _more = By.LinkText("More");
        private By _quickView = By.XPath("//span[contains(.,'Quick view')]");
        private By _quantity = By.Id("quantity_wanted");
        private By _plus = By.CssSelector(".icon-plus");
        private By _minus = By.CssSelector(".button-minus > span");
        private By _size = By.Id("group_1");
        private By _addToWishlist = By.Id("wishlist_button");
        
        //сторонние сети
        private By _twitter = By.CssSelector(".btn-twitter");
        private By _share = By.CssSelector(".btn-facebook");
        private By _google = By.CssSelector(".btn-google-plus");
        private By _pinterest = By.CssSelector(".btn-pinterest");
        //переход в Selenium
        private By _selenium = By.XPath("//li[2]/div/p/a");

        public Selenium ClickSelenium()
        {
            _driver.FindElement(_selenium).Click();
            return new Selenium(_driver);
        }

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

        public Body ClickQuickViewBlouse()
        {
            Actions actions = new Actions(_driver);
            IWebElement element = _driver.FindElement(_blouse);
            actions.MoveToElement(element).Perform();
            _driver.FindElement(_quickView).Click();
            return this;
        }

        public Body ClickQuickViewBlouseSize()
        {
            Actions actions = new Actions(_driver);
            IWebElement element = _driver.FindElement(_blouse);
            actions.MoveToElement(element).Perform();
            IWebElement quickView = _driver.FindElement(_quickView);
            quickView.Click();
            IWebElement size = _driver.FindElement(_size);
            size.Click();
            size.SendKeys(Keys.ArrowDown);
            size.SendKeys(Keys.Enter);
            return this;
        }

        public Body ClickQuickViewBlouseQuantity()
        {
            Actions actions = new Actions(_driver);
            IWebElement element = _driver.FindElement(_blouse);
            actions.MoveToElement(element).Perform();
            IWebElement quickView = _driver.FindElement(_quickView);
            quickView.Click();
            IWebElement plus = _driver.FindElement(_plus);
            plus.Click();
            IWebElement minus = _driver.FindElement(_minus);
            minus.Click();
            IWebElement quantity = _driver.FindElement(_quantity);
            quantity.SendKeys("5");
            quantity.SendKeys(Keys.Enter);
            return this;
        }

        public Body ClickQuickViewBlouseColor()
        {
            Actions actions = new Actions(_driver);
            IWebElement element = _driver.FindElement(_blouse);
            actions.MoveToElement(element).Perform();
            IWebElement quickView = _driver.FindElement(_quickView);
            quickView.Click();
            IWebElement color1 = _driver.FindElement(By.CssSelector("#color_8"));
            color1.Click();
            IWebElement color2 = _driver.FindElement(By.CssSelector("#color_11"));
            color2.Click();
            return this;
        }

        public TwitterQuickView ClickQuickViewBlouseTwitter()
        {
            _driver.FindElement(_blouse).FindElement(_quickView).Click();
            _driver.FindElement(_twitter).Click();
            return new TwitterQuickView(_driver);
        }

        public ShareQuickView ClickQuickViewBlouseShare()
        {
            _driver.FindElement(_blouse).FindElement(_quickView).Click();
            _driver.FindElement(_share).Click();
            return new ShareQuickView(_driver);
        }

        public GoogleQuickView ClickQuickViewBlouseGoogle()
        {
            _driver.FindElement(_blouse).FindElement(_quickView).Click();
            _driver.FindElement(_google).Click();
            return new GoogleQuickView(_driver);
        }

        public PinterestQuickView ClickQuickViewBlousePinterest()
        {
            _driver.FindElement(_blouse).FindElement(_quickView).Click();
            _driver.FindElement(_pinterest).Click();
            return new PinterestQuickView(_driver);
        }

        public Body ClickButtonMorelistBlouse()
        {
            _driver.FindElement(_blouse).FindElement(_quickView);
            _driver.FindElement(_more).Click();
            return this;
        }

        public Body ClickButtonAddToWishlistBlouse()
        {
            _driver.FindElement(_blouse).FindElement(_quickView);
            _driver.FindElement(_addToWishlist).Click();
            return this;
        }

        public AddToCart ClickAddToCartBlouse()
        {
            _driver.FindElement(_blouse).FindElement(_quickView);
            _driver.FindElement(_addToCart).Click();
            return new AddToCart(_driver);
        }

        public PrintedChiffonDress ClickPrintedChiffonDressSeeDescription()
        {
            _driver.FindElement(_printedChiffonDress).Click();
            return new PrintedChiffonDress(_driver);
        }

        public Body ClickQuickViewPrintedChiffonDress()
        {
            Actions actions = new Actions(_driver);
            IWebElement element = _driver.FindElement(_printedChiffonDress);
            actions.MoveToElement(element).Perform();
            _driver.FindElement(_quickView).Click();
            return this;
        }

        public Body ClickQuickViewPrintedChiffonDressSize()
        {
            Actions actions = new Actions(_driver);
            IWebElement element = _driver.FindElement(_printedChiffonDress);
            actions.MoveToElement(element).Perform();
            IWebElement quickView = _driver.FindElement(_quickView);
            quickView.Click();
            IWebElement size = _driver.FindElement(_size);
            size.Click();
            size.SendKeys(Keys.ArrowDown);
            size.SendKeys(Keys.Enter);
            return this;
        }

        public Body ClickQuickViewPrintedChiffonDressQuantity()
        {
            Actions actions = new Actions(_driver);
            IWebElement element = _driver.FindElement(_printedChiffonDress);
            actions.MoveToElement(element).Perform();
            IWebElement quickView = _driver.FindElement(_quickView);
            quickView.Click();
            IWebElement plus = _driver.FindElement(_plus);
            plus.Click();
            IWebElement minus = _driver.FindElement(_minus);
            minus.Click();
            IWebElement quantity = _driver.FindElement(_quantity);
            quantity.SendKeys("5");
            quantity.SendKeys(Keys.Enter);
            return this;
        }

        public Body ClickQuickViewPrintedChiffonDressColor()
        {
            Actions actions = new Actions(_driver);
            IWebElement element = _driver.FindElement(_printedChiffonDress);
            actions.MoveToElement(element).Perform();
            IWebElement quickView = _driver.FindElement(_quickView);
            quickView.Click();
            IWebElement color1 = _driver.FindElement(By.Id("color_15"));
            color1.Click();
            IWebElement color2 = _driver.FindElement(By.Id("color_16"));
            color2.Click();
            return this;
        }

        public TwitterQuickView ClickQuickViewPrintedChiffonDressTwitter()
        {
            _driver.FindElement(_printedChiffonDress).FindElement(_quickView).Click();
            _driver.FindElement(_twitter).Click();
            return new TwitterQuickView(_driver);
        }

        public ShareQuickView ClickQuickViewPrintedChiffonDressShare()
        {
            _driver.FindElement(_printedChiffonDress).FindElement(_quickView).Click();
            _driver.FindElement(_share).Click();
            return new ShareQuickView(_driver);
        }

        public GoogleQuickView ClickQuickViewPrintedChiffonDressGoogle()
        {
            _driver.FindElement(_printedChiffonDress).FindElement(_quickView).Click();
            _driver.FindElement(_google).Click();
            return new GoogleQuickView(_driver);
        }

        public PinterestQuickView ClickQuickViewPrintedChiffonDressPinterest()
        {
            _driver.FindElement(_printedChiffonDress).FindElement(_quickView).Click();
            _driver.FindElement(_pinterest).Click();
            return new PinterestQuickView(_driver);
        }

        public Body ClickButtonMorelistPrintedChiffonDress()
        {
            _driver.FindElement(_printedChiffonDress).FindElement(_quickView);
            _driver.FindElement(_more).Click();
            return this;
        }

        public Body ClickButtonAddToWishlistPrintedChiffonDress()
        {
            _driver.FindElement(_printedChiffonDress).FindElement(_quickView);
            _driver.FindElement(_addToWishlist).Click();
            return this;
        }

        public AddToCart ClickAddToCartPrintedChiffonDress()
        {
            _driver.FindElement(_printedChiffonDress).FindElement(_quickView);
            _driver.FindElement(_addToCart).Click();
            return new AddToCart(_driver);
        }

        public PrintedDress ClickPrintedDressSeeDescription()
        {
            _driver.FindElement(_printedDress).Click();
            return new PrintedDress(_driver);
        }

        public Body ClickQuickViewPrintedDress()
        {
            Actions actions = new Actions(_driver);
            IWebElement element = _driver.FindElement(_printedDress);
            actions.MoveToElement(element).Perform();
            _driver.FindElement(_quickView).Click();
            return this;
        }

        public Body ClickQuickViewPrintedDressSize()
        {
            Actions actions = new Actions(_driver);
            IWebElement element = _driver.FindElement(_printedDress);
            actions.MoveToElement(element).Perform();
            IWebElement quickView = _driver.FindElement(_quickView);
            quickView.Click();
            IWebElement size = _driver.FindElement(_size);
            size.Click();
            size.SendKeys(Keys.ArrowDown);
            size.SendKeys(Keys.Enter);
            return this;
        }

        public Body ClickQuickViewPrintedDressQuantity()
        {
            Actions actions = new Actions(_driver);
            IWebElement element = _driver.FindElement(_printedDress);
            actions.MoveToElement(element).Perform();
            IWebElement quickView = _driver.FindElement(_quickView);
            quickView.Click();
            IWebElement plus = _driver.FindElement(_plus);
            plus.Click();
            IWebElement minus = _driver.FindElement(_minus);
            minus.Click();
            IWebElement quantity = _driver.FindElement(_quantity);
            quantity.SendKeys("5");
            quantity.SendKeys(Keys.Enter);
            return this;
        }

        public Body ClickQuickViewPrintedDressColor()
        {
            Actions actions = new Actions(_driver);
            IWebElement element = _driver.FindElement(_printedDress);
            actions.MoveToElement(element).Perform();
            IWebElement quickView = _driver.FindElement(_quickView);
            quickView.Click();
            IWebElement color = _driver.FindElement(By.Id("color_13"));
            color.Click();            
            return this;
        }

        public TwitterQuickView ClickQuickViewPrintedDressTwitter()
        {
            _driver.FindElement(_printedDress).FindElement(_quickView).Click();
            _driver.FindElement(_twitter).Click();
            return new TwitterQuickView(_driver);
        }

        public ShareQuickView ClickQuickViewPrintedDressShare()
        {
            _driver.FindElement(_printedDress).FindElement(_quickView).Click();
            _driver.FindElement(_share).Click();
            return new ShareQuickView(_driver);
        }

        public GoogleQuickView ClickQuickViewPrintedDressGoogle()
        {
            _driver.FindElement(_printedDress).FindElement(_quickView).Click();
            _driver.FindElement(_google).Click();
            return new GoogleQuickView(_driver);
        }

        public PinterestQuickView ClickQuickViewPrintedDressPinterest()
        {
            _driver.FindElement(_printedDress).FindElement(_quickView).Click();
            _driver.FindElement(_pinterest).Click();
            return new PinterestQuickView(_driver);
        }

        public Body ClickButtonMorelistPrintedDress()
        {
            _driver.FindElement(_printedDress).FindElement(_quickView);
            _driver.FindElement(_more).Click();
            return this;
        }

        public Body ClickButtonAddToWishlistPrintedDress()
        {
            _driver.FindElement(_printedDress).FindElement(_quickView);
            _driver.FindElement(_addToWishlist).Click();
            return this;
        }

        public AddToCart ClickAddToCartPrintedDress()
        {
            _driver.FindElement(_printedDress).FindElement(_quickView);
            _driver.FindElement(_addToCart).Click();
            return new AddToCart(_driver);
        }

        public PrintedDress2 ClickPrintedDress2SeeDescription()
        {
            _driver.FindElement(_printedDress2).Click();
            return new PrintedDress2(_driver);
        }

        public Body ClickQuickViewPrintedDress2()
        {
            Actions actions = new Actions(_driver);
            IWebElement element = _driver.FindElement(_printedDress2);
            actions.MoveToElement(element).Perform();
            _driver.FindElement(_quickView).Click();
            return this;
        }

        public Body ClickQuickViewPrintedDress2Size()
        {
            Actions actions = new Actions(_driver);
            IWebElement element = _driver.FindElement(_printedDress2);
            actions.MoveToElement(element).Perform();
            IWebElement quickView = _driver.FindElement(_quickView);
            quickView.Click();
            IWebElement size = _driver.FindElement(_size);
            size.Click();
            size.SendKeys(Keys.ArrowDown);
            size.SendKeys(Keys.Enter);
            return this;
        }

        public Body ClickQuickViewPrintedDress2Quantity()
        {
            Actions actions = new Actions(_driver);
            IWebElement element = _driver.FindElement(_printedDress2);
            actions.MoveToElement(element).Perform();
            IWebElement quickView = _driver.FindElement(_quickView);
            quickView.Click();
            IWebElement plus = _driver.FindElement(_plus);
            plus.Click();
            IWebElement minus = _driver.FindElement(_minus);
            minus.Click();
            IWebElement quantity = _driver.FindElement(_quantity);
            quantity.SendKeys("5");
            quantity.SendKeys(Keys.Enter);
            return this;
        }

        public Body ClickQuickViewPrintedDress2Color()
        {
            Actions actions = new Actions(_driver);
            IWebElement element = _driver.FindElement(_printedDress2);
            actions.MoveToElement(element).Perform();
            IWebElement quickView = _driver.FindElement(_quickView);
            quickView.Click();
            IWebElement color1 = _driver.FindElement(By.Id("color_7"));
            color1.Click();
            IWebElement color2 = _driver.FindElement(By.Id("color_24"));
            color2.Click();
            return this;
        }

        public TwitterQuickView ClickQuickViewPrintedDress2Twitter()
        {
            _driver.FindElement(_printedDress2).FindElement(_quickView).Click();
            _driver.FindElement(_twitter).Click();
            return new TwitterQuickView(_driver);
        }

        public ShareQuickView ClickQuickViewPrintedDress2Share()
        {
            _driver.FindElement(_printedDress2).FindElement(_quickView).Click();
            _driver.FindElement(_share).Click();
            return new ShareQuickView(_driver);
        }

        public GoogleQuickView ClickQuickViewPrintedDress2Google()
        {
            _driver.FindElement(_printedDress2).FindElement(_quickView).Click();
            _driver.FindElement(_google).Click();
            return new GoogleQuickView(_driver);
        }

        public PinterestQuickView ClickQuickViewPrintedDress2Pinterest()
        {
            _driver.FindElement(_printedDress2).FindElement(_quickView).Click();
            _driver.FindElement(_pinterest).Click();
            return new PinterestQuickView(_driver);
        }

        public Body ClickButtonMorelistPrintedDress2()
        {
            _driver.FindElement(_printedDress2).FindElement(_quickView);
            _driver.FindElement(_more).Click();
            return this;
        }

        public Body ClickButtonAddToWishlistPrintedDress2()
        {
            _driver.FindElement(_printedDress2).FindElement(_quickView);
            _driver.FindElement(_addToWishlist).Click();
            return this;
        }

        public AddToCart ClickAddToCartPrintedDress2()
        {
            _driver.FindElement(_printedDress2).FindElement(_quickView);
            _driver.FindElement(_addToCart).Click();
            return new AddToCart(_driver);
        }

        public PrintedSummerDress ClickPrintedSummerDressSeeDescription()
        {
            _driver.FindElement(_printedSummerDress).Click();
            return new PrintedSummerDress(_driver);
        }

        public Body ClickQuickViewPrintedSummerDress()
        {
            Actions actions = new Actions(_driver);
            IWebElement element = _driver.FindElement(_printedSummerDress);
            actions.MoveToElement(element).Perform();
            _driver.FindElement(_quickView).Click();
            return this;
        }

        public Body ClickQuickViewPrintedSummerDressSize()
        {
            Actions actions = new Actions(_driver);
            IWebElement element = _driver.FindElement(_printedSummerDress);
            actions.MoveToElement(element).Perform();
            IWebElement quickView = _driver.FindElement(_quickView);
            quickView.Click();
            IWebElement size = _driver.FindElement(_size);
            size.Click();
            size.SendKeys(Keys.ArrowDown);
            size.SendKeys(Keys.Enter);
            return this;
        }

        public Body ClickQuickViewPrintedSummerDressQuantity()
        {
            Actions actions = new Actions(_driver);
            IWebElement element = _driver.FindElement(_printedSummerDress);
            actions.MoveToElement(element).Perform();
            IWebElement quickView = _driver.FindElement(_quickView);
            quickView.Click();
            IWebElement plus = _driver.FindElement(_plus);
            plus.Click();
            IWebElement minus = _driver.FindElement(_minus);
            minus.Click();
            IWebElement quantity = _driver.FindElement(_quantity);
            quantity.SendKeys("5");
            quantity.SendKeys(Keys.Enter);
            return this;
        }

        public Body ClickQuickViewPrintedSummerDressColor()
        {
            Actions actions = new Actions(_driver);
            IWebElement element = _driver.FindElement(_printedSummerDress);
            actions.MoveToElement(element).Perform();
            IWebElement quickView = _driver.FindElement(_quickView);
            quickView.Click();
            IWebElement color1 = _driver.FindElement(By.Id("color_11"));
            color1.Click();
            IWebElement color2 = _driver.FindElement(By.Id("color_13"));
            color2.Click();
            IWebElement color3 = _driver.FindElement(By.Id("color_11"));
            color3.Click();
            IWebElement color4 = _driver.FindElement(By.Id("color_13"));
            color4.Click();
            return this;
        }

        public TwitterQuickView ClickQuickViewPrintedSummerDressTwitter()
        {
            _driver.FindElement(_printedSummerDress).FindElement(_quickView).Click();
            _driver.FindElement(_twitter).Click();
            return new TwitterQuickView(_driver);
        }

        public ShareQuickView ClickQuickViewPrintedSummerDressShare()
        {
            _driver.FindElement(_printedSummerDress).FindElement(_quickView).Click();
            _driver.FindElement(_share).Click();
            return new ShareQuickView(_driver);
        }

        public GoogleQuickView ClickQuickViewPrintedSummerDressGoogle()
        {
            _driver.FindElement(_printedSummerDress).FindElement(_quickView).Click();
            _driver.FindElement(_google).Click();
            return new GoogleQuickView(_driver);
        }

        public PinterestQuickView ClickQuickViewPrintedSummerDressPinterest()
        {
            _driver.FindElement(_printedSummerDress).FindElement(_quickView).Click();
            _driver.FindElement(_pinterest).Click();
            return new PinterestQuickView(_driver);
        }

        public Body ClickButtonMorelistPrintedSummerDress()
        {
            _driver.FindElement(_printedSummerDress).FindElement(_quickView);
            _driver.FindElement(_more).Click();
            return this;
        }

        public Body ClickButtonAddToWishlistPrintedSummerDress()
        {
            _driver.FindElement(_printedSummerDress).FindElement(_quickView);
            _driver.FindElement(_addToWishlist).Click();
            return this;
        }

        public AddToCart ClickAddToCartPrintedSummerDress()
        {
            _driver.FindElement(_printedSummerDress).FindElement(_quickView);
            _driver.FindElement(_addToCart).Click();
            return new AddToCart(_driver);
        }

        public PrintedSummerDress2 ClickPrintedSummerDress2SeeDescription()
        {
            _driver.FindElement(_printedSummerDress2).Click();
            return new PrintedSummerDress2(_driver);
        }

        public Body ClickQuickViewPrintedSummerDress2()
        {
            Actions actions = new Actions(_driver);
            IWebElement element = _driver.FindElement(_printedSummerDress2);
            actions.MoveToElement(element).Perform();
            _driver.FindElement(_quickView).Click();
            return this;
        }

        public Body ClickQuickViewPrintedSummerDress2Size()
        {
            Actions actions = new Actions(_driver);
            IWebElement element = _driver.FindElement(_printedSummerDress2);
            actions.MoveToElement(element).Perform();
            IWebElement quickView = _driver.FindElement(_quickView);
            quickView.Click();
            IWebElement size = _driver.FindElement(_size);
            size.Click();
            size.SendKeys(Keys.ArrowDown);
            size.SendKeys(Keys.Enter);
            return this;
        }

        public Body ClickQuickViewPrintedSummerDress2Quantity()
        {
            Actions actions = new Actions(_driver);
            IWebElement element = _driver.FindElement(_printedSummerDress2);
            actions.MoveToElement(element).Perform();
            IWebElement quickView = _driver.FindElement(_quickView);
            quickView.Click();
            IWebElement plus = _driver.FindElement(_plus);
            plus.Click();
            IWebElement minus = _driver.FindElement(_minus);
            minus.Click();
            IWebElement quantity = _driver.FindElement(_quantity);
            quantity.SendKeys("5");
            quantity.SendKeys(Keys.Enter);
            return this;
        }

        public Body ClickQuickViewPrintedSummerDress2Color()
        {
            Actions actions = new Actions(_driver);
            IWebElement element = _driver.FindElement(_printedSummerDress2);
            actions.MoveToElement(element).Perform();
            IWebElement quickView = _driver.FindElement(_quickView);
            quickView.Click();
            IWebElement color1 = _driver.FindElement(By.Id("color_8"));
            color1.Click();
            IWebElement color2 = _driver.FindElement(By.Id("color_16"));
            color2.Click();
            return this;
        }

        public TwitterQuickView ClickQuickViewPrintedSummerDress2Twitter()
        {
            _driver.FindElement(_printedSummerDress2).FindElement(_quickView).Click();
            _driver.FindElement(_twitter).Click();
            return new TwitterQuickView(_driver);
        }

        public ShareQuickView ClickQuickViewPrintedSummerDress2Share()
        {
            _driver.FindElement(_printedSummerDress2).FindElement(_quickView).Click();
            _driver.FindElement(_share).Click();
            return new ShareQuickView(_driver);
        }

        public GoogleQuickView ClickQuickViewPrintedSummerDress2Google()
        {
            _driver.FindElement(_printedSummerDress2).FindElement(_quickView).Click();
            _driver.FindElement(_google).Click();
            return new GoogleQuickView(_driver);
        }

        public PinterestQuickView ClickQuickViewPrintedSummerDress2Pinterest()
        {
            _driver.FindElement(_printedSummerDress2).FindElement(_quickView).Click();
            _driver.FindElement(_pinterest).Click();
            return new PinterestQuickView(_driver);
        }

        public Body ClickButtonMorelistPrintedSummerDress2()
        {
            _driver.FindElement(_printedSummerDress2).FindElement(_quickView);
            _driver.FindElement(_more).Click();
            return this;
        }

        public Body ClickButtonAddToWishlistPrintedSummerDress2()
        {
            _driver.FindElement(_printedSummerDress2).FindElement(_quickView);
            _driver.FindElement(_addToWishlist).Click();
            return this;
        }

        public AddToCart ClickAddToCartPrintedSummerDress2()
        {
            _driver.FindElement(_printedSummerDress2).FindElement(_quickView);
            _driver.FindElement(_addToCart).Click();
            return new AddToCart(_driver);
        }

        public ShortSleeve ClickShortSleeveSeeDescription()
        {
            _driver.FindElement(_fadedShortSleeve).Click();
            return new ShortSleeve(_driver);
        }

        public QuickView ClickQuickViewOpen()
        {
            _driver.FindElement(_quickView).Click();
            return new QuickView(_driver);
        }

        public Body ClickQuickViewShortSleeve()
        {
            Actions actions = new Actions(_driver);
            IWebElement element = _driver.FindElement(_fadedShortSleeve);
            actions.MoveToElement(element).Perform();
            _driver.FindElement(_quickView).Click();
            return this;
        }

        public Body ClickQuickViewShortSleeveSize()
        {
            Actions actions = new Actions(_driver);
            IWebElement element = _driver.FindElement(_fadedShortSleeve);
            actions.MoveToElement(element).Perform();
            IWebElement quickView = _driver.FindElement(_quickView);
            quickView.Click();
            IWebElement size = _driver.FindElement(_size);
            size.Click();
            size.SendKeys(Keys.ArrowDown);
            size.SendKeys(Keys.Enter);
            return this;
        }

        public Body ClickQuickViewShortSleeveQuantity()
        {
            Actions actions = new Actions(_driver);
            IWebElement element = _driver.FindElement(_fadedShortSleeve);
            actions.MoveToElement(element).Perform();
            IWebElement quickView = _driver.FindElement(_quickView);
            quickView.Click();
            IWebElement plus = _driver.FindElement(_plus);
            plus.Click();
            IWebElement minus = _driver.FindElement(_minus);
            minus.Click();
            IWebElement quantity = _driver.FindElement(_quantity);
            quantity.SendKeys("5");
            quantity.SendKeys(Keys.Enter);
            return this;
        }

        public Body ClickQuickViewShortSleeveColor()
        {
            Actions actions = new Actions(_driver);
            IWebElement element = _driver.FindElement(_fadedShortSleeve);
            actions.MoveToElement(element).Perform();
            IWebElement quickView = _driver.FindElement(_quickView);
            quickView.Click();
            IWebElement color1 = _driver.FindElement(By.Id("color_13"));
            color1.Click();
            IWebElement color2 = _driver.FindElement(By.Id("color_14"));
            color2.Click();
            return this;
        }

        public TwitterQuickView ClickQuickViewShortSleeveTwitter()
        {
            _driver.FindElement(_fadedShortSleeve).FindElement(_quickView).Click();
            _driver.FindElement(_twitter).Click();
            return new TwitterQuickView(_driver);
        }

        public ShareQuickView ClickQuickViewShortSleeveShare()
        {
            _driver.FindElement(_fadedShortSleeve).FindElement(_quickView).Click();
            _driver.FindElement(_share).Click();
            return new ShareQuickView(_driver);
        }

        public GoogleQuickView ClickQuickViewShortSleeveGoogle()
        {
            _driver.FindElement(_fadedShortSleeve).FindElement(_quickView).Click();
            _driver.FindElement(_google).Click();
            return new GoogleQuickView(_driver);
        }

        public PinterestQuickView ClickQuickViewShortSleevePinterest()
        {
            _driver.FindElement(_fadedShortSleeve).FindElement(_quickView).Click();
            _driver.FindElement(_pinterest).Click();
            return new PinterestQuickView(_driver);
        }

        public Body ClickButtonMorelistShortSleeve()
        {
            _driver.FindElement(_fadedShortSleeve).FindElement(_quickView);
            _driver.FindElement(_more).Click();
            return this;
        }

        public Body ClickButtonAddToWishlistShortSleeve()
        {
            _driver.FindElement(_fadedShortSleeve).FindElement(_quickView);
            _driver.FindElement(_addToWishlist).Click();
            return this;
        }

        public AddToCart ClickAddToCartShortSleeve()
        {
            _driver.FindElement(_fadedShortSleeve).FindElement(_quickView);
            _driver.FindElement(_addToCart).Click();
            return new AddToCart(_driver);
        }
    }
}
