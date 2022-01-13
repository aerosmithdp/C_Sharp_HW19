using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;
using PracticeSelenium13012022.PageObject;


namespace PracticeSelenium13012022
{
    public class UnitTest1 : BaseTest
    {
        [Fact]
        public void TestBanner()
        {
            IWebDriver driver = StartDriverOnPage("http://automationpractice.com/index.php");
            HomePage homePage = new(driver);
            homePage.ClickBanner();
        }                         
                                 
        [Fact]                    
        public void TestContactUs()
        {                         
            IWebDriver driver = StartDriverOnPage("http://automationpractice.com/index.php");
            HomePage homePage = new(driver);
            homePage.ClickContactUs();
        }

        [Fact]
        public void TestSignIn()
        {
            IWebDriver driver = StartDriverOnPage("http://automationpractice.com/index.php");
            HomePage homePage = new(driver);
            homePage.ClickSignIn();
        }

        [Fact]
        public void TestLogo()
        {
            IWebDriver driver = StartDriverOnPage("http://automationpractice.com/index.php");
            HomePage homePage = new(driver);
            homePage.ClickLogo();
        }

        [Fact]
        public void TestSearch()
        {
            IWebDriver driver = StartDriverOnPage("http://automationpractice.com/index.php");
            HomePage homePage = new(driver);
            homePage.ClickSearch();     
        }

        [Fact]
        public void TestSearchButton()
        {
            IWebDriver driver = StartDriverOnPage("http://automationpractice.com/index.php");
            HomePage homePage = new(driver);
            homePage.ClickSearchButton();
        }

        [Fact]
        public void TestCart()
        {
            IWebDriver driver = StartDriverOnPage("http://automationpractice.com/index.php");
            HomePage homePage = new(driver);
            homePage.ClickSearchButton();
        }

        [Fact]
        public void TestWomenHover()
        {
            IWebDriver driver = StartDriverOnPage("http://automationpractice.com/index.php");
            HomePage homePage = new(driver);
            homePage.ClickWomenHover();
        }

        [Fact]
        public void TestWomenHoverTops()
        {
            IWebDriver driver = StartDriverOnPage("http://automationpractice.com/index.php");
            HomePage homePage = new(driver);
            homePage.WomenHoverClickTops();
        }




    }
}
