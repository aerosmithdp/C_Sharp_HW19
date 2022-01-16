using OpenQA.Selenium;
using System;

//sheremet
namespace C_Sharp_HW19.PageObjects

{
    public class ForgotPassword : Header
    {
        public ForgotPassword(IWebDriver driver)
        {
            _driver = driver;
        }

        private readonly By _fieldEmail = By.XPath("//input[@id='email']");
        private readonly By _retrievePassword = By.XPath("//form[@id='form_forgotpassword']/fieldset/p/button/span");
        private readonly By _returnButton = By.XPath("//div[@id='center_column']/ul/li/a/span");

        public ForgotPassword ResetPasswordSendEmail()
        {
            _driver.FindElement(_fieldEmail).SendKeys("qwerty1223@mail.ru");
            return this;
        }

        public ForgotPassword CkickRetrieveButton()
        {
            _driver.FindElement(_retrievePassword).Click();
            return this;
        }

        public SignIn ConfirmFirstName()
        {
            _driver.FindElement(_returnButton).Click();
            return new SignIn(_driver) ;
        }


    }
}