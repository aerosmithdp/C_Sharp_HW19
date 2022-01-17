using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;
using C_Sharp_HW19.PageObjects;


namespace C_Sharp_HW19
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


    }
}
