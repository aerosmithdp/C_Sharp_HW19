using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace C_Sharp_HW19.PageObjects
{
    public class Body
    {
        protected IWebDriver _driver;

        private By _bunnerSale = By.XPath("//img[contains(@src,'http://automationpractice.com/modules/themeconfigurator/img/banner-img6.jpg')]");
        private By _bunnerOnlyOnline = By.XPath("//img[contains(@src,'http://automationpractice.com/modules/themeconfigurator/img/banner-img7.jpg')]");
        private By _bunnerTopTrends = By.XPath("//img[contains(@src,'http://automationpractice.com/modules/themeconfigurator/img/banner-img1.jpg')]");
        private By _bunnerMens = By.XPath("//img[contains(@src,'http://automationpractice.com/modules/themeconfigurator/img/banner-img2.jpg')]");
        private By _bunnerWomens = By.XPath("//img[contains(@src,'http://automationpractice.com/modules/themeconfigurator/img/banner-img3.jpg')]");
        private By _bunnerSunGlasses = By.XPath("//img[contains(@src,'http://automationpractice.com/modules/themeconfigurator/img/banner-img4.jpg')]");
        private By _bunnerSavvyTrends = By.XPath("//img[contains(@src,'http://automationpractice.com/modules/themeconfigurator/img/banner-img5.jpg')]");

        private By _bunnerExcepteur1 = By.Id("");
        private By _bunnerExcepteur2 = By.Id("");
        private By _bunnerExcepteur3 = By.Id("");
        private By _buttonShopNowExcepteur1 = By.XPath("");
        private By _buttonShopNowExcepteur2 = By.XPath("");
        private By _buttonShopNowExcepteur3 = By.XPath("");

        private By _button = By.XPath("");

        private By _popular = By.Id("");
        private By _bestSellers = By.Id("");
    }
}
