using OpenQA.Selenium;
using System;


namespace C_Sharp_HW19.PageObjects

{
    public class MyPersonalInformation : Header
    {
        public MyPersonalInformation(IWebDriver driver)
        {
            _driver = driver;
        }

        private readonly By _maleCheckbox = By.XPath("//input[@id='id_gender1']");
        private readonly By _femaleCheckbox = By.XPath("//input[@id='id_gender2']");
        private readonly By _firstNamefield = By.XPath("//input[@id='customer_firstname']");
        private readonly By _lastNamefield = By.XPath("//input[@id='customer_lastname']");
        private readonly By _passwordField = By.XPath("//input[@id='passwd']");
        private readonly By _fieldEmail = By.XPath("//input[@id='email_create']");
        private readonly By _newsletterCheckbox = By.XPath("//input[@id='optin']");
        private readonly By _offersCheckbox = By.XPath("//input[@id='newsletter']");
        private readonly By _scrollDays = By.XPath("//select[@id='days']");
        private readonly By _scrolMonths = By.XPath("//select[@id='months']");
        private readonly By _scrollYears = By.XPath("//select[@id='years']");
        private readonly By _goBackToMainMenu = By.XPath("//div[@id='center_column']/ul/li/a/span");
        private readonly By _goBackToAccountMenu = By.XPath("//div[@id='center_column']/ul/li[2]/a/span");


        public MyPersonalInformation ChooseMaleCheckbox()
        {
            _driver.FindElement(_maleCheckbox).SendKeys("qwerty1224@mail.ru");
            return this;
        }

        public MyPersonalInformation ChooseFemaleCheckbox()
        {
            _driver.FindElement(_femaleCheckbox).Click();
            return this;
        }

        public MyPersonalInformation InputFirstName()
        {
            _driver.FindElement(_firstNamefield).SendKeys("Petya");
            return this;
        }

        public MyPersonalInformation InputLasttName()
        {
            _driver.FindElement(_lastNamefield).SendKeys("Masha");
            return this;
        }

        public MyPersonalInformation InputPassword()
        {
            _driver.FindElement(_passwordField).SendKeys("123456");
            return this;
        }

        public MyPersonalInformation EmailInput()
        {
            _driver.FindElement(_fieldEmail).SendKeys("qwerty1224@mail.ru");
            return this;
        }

        public MyPersonalInformation NewsletterCheckboxClick()
        {
            _driver.FindElement(_newsletterCheckbox).Click();
            return this;
        }

        public MyPersonalInformation OffersCheckboxClick()
        {
            _driver.FindElement(_offersCheckbox).Click();
            return this;
        }

        public MyPersonalInformation DayOfBirthScrollClick()
        {
            _driver.FindElement(_scrollDays).Click();
            _driver.FindElement(_scrollDays).SendKeys("8");
            _driver.FindElement(_scrollDays).SendKeys(Keys.Enter);
            return this;
        }

        public MyPersonalInformation MonthOfBirthScrollClick()
        {
            _driver.FindElement(_scrolMonths).Click();
            _driver.FindElement(_scrolMonths).SendKeys("January");
            _driver.FindElement(_scrolMonths).SendKeys(Keys.Enter);
            return this;
        }

        public MyPersonalInformation YearOfBirthChooseClick()
        {
            _driver.FindElement(_scrollYears).Click();
            _driver.FindElement(_scrollYears).SendKeys("1991");
            _driver.FindElement(_scrollYears).SendKeys(Keys.Enter);
            return this;
        }

        public HomePage GoBackToMainMenuFromAccount()
        {
            _driver.FindElement(_goBackToMainMenu).Click();
            return new HomePage(_driver);
        }

        public MyAccount GoBackToAccountMenuFromOrderHistoryPage()
        {
            _driver.FindElement(_goBackToAccountMenu).Click();
            return new MyAccount(_driver);
        }
    }
}
