using OpenQA.Selenium;
using System;

//Sheremet
namespace C_Sharp_HW19.PageObjects
{
    public class SignInViaCartMenu : Header
    {
        public SignInViaCartMenu(IWebDriver driver)
        {
            _driver = driver;
        }

        //Cart step2
        private readonly By _fieldEmail = By.XPath("//input[@id='email_create']");
        private readonly By _createAccountButton = By.XPath("//button[@id='SubmitCreate']/span");
        private readonly By _inputEmailField = By.XPath("//input[@id='email']");
        private readonly By _inputPasswordField = By.XPath("//input[@id='passwd']");
        private readonly By _forgotPassword = By.XPath("//a[contains(text(),'Forgot your password?')]");
        private readonly By _submitButton = By.XPath("//button[@id='SubmitLogin']/span");

        public SignInViaCartMenu EmailInput()
        {
            _driver.FindElement(_fieldEmail).SendKeys("qwerty1224@mail.ru");
            return this;
        }

        public AccountCreation CreateButtonClick()
        {
            _driver.FindElement(_createAccountButton).Click();
            return new AccountCreation(_driver);
        }

        public SignInViaCartMenu AlreadyRegisteredEmailInput()
        {
            _driver.FindElement(_inputEmailField).SendKeys("qwerty1223@mail.ru");
            return this;
        }

        public SignInViaCartMenu PasswordInput()
        {
            _driver.FindElement(_inputPasswordField).SendKeys("123456");
            return this;
        }

        public ForgotPassword ForgotPasswordMenu()
        {
            _driver.FindElement(_forgotPassword).Click();
            return new ForgotPassword(_driver);
        }

        public ChooseAddresses EnterAccount()
        {
            _driver.FindElement(_submitButton).Click();
            return new ChooseAddresses(_driver);
        }
    }
}