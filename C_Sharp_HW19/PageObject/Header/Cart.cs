using OpenQA.Selenium;
using System;

  // Sheremet
namespace C_Sharp_HW19.PageObjects
{
    public class Cart : Header
    {
        public Cart(IWebDriver driver)
        {
            _driver = driver;
        }

        // Cart step1
        private readonly By _clickOnImage = By.XPath("(//img[@alt='Faded Short Sleeve T-shirts'])[3]");
        private readonly By _clickLink = By.XPath("(//a[contains(text(),'Faded Short Sleeve T-shirts')])[2]");
        private readonly By _addItem = By.XPath("//a[@id='cart_quantity_up_1_1_0_632299']/span/i");
        private readonly By _decreaseAmountOfItem = By.XPath("//a[@id='cart_quantity_down_1_1_0_632299']/span");
        private readonly By _deleteItemTotally = By.XPath("//a[@id='1_1_0_632299']/i");
        private readonly By _procedeToCheckout = By.XPath("//div[@id='center_column']/p[2]/a/span");
        private readonly By _continueShopping = By.XPath("//div[@id='center_column']/p[2]/a[2]");

        //Cart step2
        private readonly By _fieldEmail = By.XPath("//input[@id='email_create']");
        private readonly By _createAccountButton = By.XPath("//button[@id='SubmitCreate']/span");
        private readonly By _inputEmailField = By.XPath("//input[@id='email']");
        private readonly By _inputPasswordField = By.XPath("//input[@id='passwd']");
        private readonly By _forgotPassword = By.XPath("//a[contains(text(),'Forgot your password?')]");
        private readonly By _submitButton = By.XPath("//button[@id='SubmitLogin']/span");



        public AddToCart ClickImageDress()
        {
            _driver.FindElement(_clickOnImage).Click();
            return new AddToCart(_driver);
        }

        public AddToCart ClicLinkDress()
        {
            _driver.FindElement(_clickLink).Click();
            return new AddToCart(_driver);
        }

        public Cart AddItemToCart()
        {
            _driver.FindElement(_addItem).Click();
            return this;
        }

        public Cart DecreaseNumberOfItems()
        {
            _driver.FindElement(_decreaseAmountOfItem).Click();
            return this;
        }

        public Cart DeleteItem()
        {
            _driver.FindElement(_deleteItemTotally).Click();
            return this;
        }

        public Cart KeepOrdering()
        {
            _driver.FindElement(_procedeToCheckout).Click();
            return this;
        }

        public HomePage ReturnToMainMenu()
        {
            _driver.FindElement(_continueShopping).Click();
            return new HomePage(_driver);
        }



        public Cart EmailInput()
        {
            _driver.FindElement(_fieldEmail).SendKeys("qwerty1224@mail.ru");
            return this;
        }

        public AccountCreation CreateButtonClick()
        {
            _driver.FindElement(_createAccountButton).Click();
            return new AccountCreation(_driver);
        }

        public Cart AlreadyRegisteredEmailInput()
        {
            _driver.FindElement(_inputEmailField).SendKeys("qwerty1223@mail.ru");
            return this;
        }

        public Cart PasswordInput()
        {
            _driver.FindElement(_inputPasswordField).SendKeys("123456");
            return this;
        }

        public ForgotPassword ForgotPasswordMenu()
        {
            _driver.FindElement(_forgotPassword).Click();
            return new ForgotPassword(_driver);
        }

        public Cart EnterAccount()
        {
            _driver.FindElement(_submitButton).Click();
            return this;
        }



    }
}