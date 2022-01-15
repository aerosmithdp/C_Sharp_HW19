using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace C_Sharp_HW19.PageObjects
{
    public class Footer
    {
        protected IWebDriver _driver;

        private By _FB = By.XPath("//a[contains(@href, 'https://www.facebook.com/groups/525066904174158/')]");
        private By _Twitter = By.XPath("//a[contains(@href, 'https://twitter.com/seleniumfrmwrk')]");
        private By _TouTube = By.XPath("//a[contains(@href, 'https://www.youtube.com/channel/UCHl59sI3SRjQ-qPcTrgt0tA')]");
        private By _Google = By.XPath("//a[contains(@href, 'https://plus.google.com/111979135243110831526/posts')]");
        private By _sbmtbtn = By.XPath("//div[@id='newsletter_block_left']/div/form/div/button");
        private By _fieldemail = By.XPath("//div[@id='newsletter_block_left']/div/form/div/input");
        private By _externallink = By.XPath("//a[@href='http://www.prestashop.com']");
        

        public Footer ClickFB()
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

        public Footer ExternalLinkClick()
        {
            _driver.FindElement(_externallink).Click(); 
            return new ExternalLink(_driver);
        }












    }
}

