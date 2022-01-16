using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;




namespace C_Sharp_HW19.PageObjects
{
    public class Footer : Header
    {
        private By _FB = By.XPath("//a[contains(@href, 'https://www.facebook.com/groups/525066904174158/')]");
        private By _Twitter = By.XPath("//a[contains(@href, 'https://twitter.com/seleniumfrmwrk')]");
        private By _TouTube = By.XPath("//a[contains(@href, 'https://www.youtube.com/channel/UCHl59sI3SRjQ-qPcTrgt0tA')]");
        private By _Google = By.XPath("//a[contains(@href, 'https://plus.google.com/111979135243110831526/posts')]");
        private By _sbmtbtn = By.XPath("//div[@id='newsletter_block_left']/div/form/div/button");
        private By _fieldemail = By.XPath("//div[@id='newsletter_block_left']/div/form/div/input");
        private By _externallink = By.XPath("//a[@href='http://www.prestashop.com']");
        private By _specialst = By.XPath("//section[@id='block_various_links_footer']/ul/li/a");
        private By _newproduct = By.XPath("//a[contains(text(),'New products')]");
        private By _bestsellers = By.XPath("//a[contains(text(),'Best sellers')]");
        private By _ourStores = By.XPath("//a[contains(text(),'Our stores')]");
        private By _contactUs = By.XPath("//section[@id='block_various_links_footer']/ul/li[5]/a");
        private By _termsAndCondits = By.XPath("//a[contains(text(),'Terms and conditions of use')]");
        private By _aboutUs = By.XPath("//a[contains(text(),'About us')]");
        private By _sitemap = By.XPath("//a[contains(text(),'Sitemap')]");
        private By _signInFooter = By.XPath("//footer[@id='footer']/div/section[5]/h4/a");
        private By _womanMenu = By.XPath("//footer[@id='footer']/div/section[5]/h4/a");
        



        public FB ClickFB()
        {
            _driver.FindElement(_FB).Click();
            return new FB(_driver);
        }
        public Twitter ClickTwitter()
        {
            _driver.FindElement(_Twitter).Click();
            return new Twitter(_driver);
        }
        public YouTube ClickYouTube()
        {
            _driver.FindElement(_TouTube).Click();
            return new YouTube(_driver);
        }
        public Google ClickGoogle()
        {
            _driver.FindElement(_Google).Click();
            return new Google(_driver); 
        }

        public Footer ClickSubmitButton()
        {
            _driver.FindElement(_sbmtbtn).Click();
            return this;
        }

        public Footer ClickFieldEmail()
        {
            _driver.FindElement(_fieldemail).Click();
            return this;
        }

        public Footer InputEmail()
        {
            _driver.FindElement(_fieldemail).SendKeys("123");
            return this;
        }

        public Footer InputEnterEmail()
        {
            _driver.FindElement(_fieldemail).SendKeys(Keys.Enter);
            return this;
        }

        public ExternalLink ExternalLinkClick()
        {
            _driver.FindElement(_externallink).Click(); 
            return new ExternalLink(_driver);
        }

        public WomenPage WomenMenuFooterClick()
        {
            _driver.FindElement(_womanMenu).Click();
            return new WomenPage(_driver);
        }

        public Specials SpecialsFooterClick()
         {
             _driver.FindElement(_specialst).Click(); 
             return new Specials(_driver);
         }

        public NewProduct NewProductClick()
        {
             _driver.FindElement(_newproduct).Click(); 
             return new NewProduct(_driver);
        }

        public BestSellers BestSellersClick()
        {
            _driver.FindElement(_bestsellers).Click();
            return new BestSellers(_driver);
        }

        public OurStores OurStoresClick()
        {
            _driver.FindElement(_ourStores).Click();
            return new OurStores(_driver);
        }

        public ContactUs ContactUsClick()
        {
            _driver.FindElement(_contactUs).Click();
            return new ContactUs(_driver);
        }

        public TermsAndConditions TermsAndConditionsClick()
        {
            _driver.FindElement(_termsAndCondits).Click();
            return new TermsAndConditions(_driver);
        }

        public AboutUs AboutUsClick()
        {
            _driver.FindElement(_aboutUs).Click();
            return new AboutUs(_driver);
        }

        public SiteMap SiteMapClick()
        {
            _driver.FindElement(_sitemap).Click();
            return new SiteMap(_driver);
        }

        public SignIn SignInClick()
        {
            _driver.FindElement(_signInFooter).Click();
            return new SignIn(_driver);
        }

    }
}

