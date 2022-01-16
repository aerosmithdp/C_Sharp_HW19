using OpenQA.Selenium;
using System;

//Sheremet
namespace C_Sharp_HW19.PageObjects

{
    public class AccountCreation : Header
    {
        public AccountCreation(IWebDriver driver)
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
        private readonly By _firstNameConfirmField = By.XPath("//input[@id='firstname']");
        private readonly By _lastNameConfirmField = By.XPath("//input[@id='lastname']");
        private readonly By _companyField = By.XPath("//input[@id='company']");
        private readonly By _addressField = By.XPath("//input[@id='address1']");
        private readonly By _addressField2 = By.XPath("//input[@id='address2']");
        private readonly By _cityField = By.XPath("//input[@id='city']");
        private readonly By _stateScroll = By.XPath("//select[@id='id_state']");
        private readonly By _postcodeField = By.XPath("//input[@id='postcode']");
        private readonly By _countryScroll = By.XPath("//select[@id='id_country']");
        private readonly By _otherField = By.XPath("//textarea[@id='other']");
        private readonly By _homePhoneField = By.XPath("//input[@id='phone']");
        private readonly By _mobilePhoneField = By.XPath("//input[@id='phone_mobile']");
        private readonly By _aliasField = By.XPath("//input[@id='alias']");
        private readonly By _submitButton = By.XPath("//button[@id='submitAccount']/span");




        public AccountCreation ChooseMaleCheckbox()
        {
            _driver.FindElement(_maleCheckbox).SendKeys("qwerty1224@mail.ru");
            return this;
        }

        public AccountCreation ChooseFemaleCheckbox()
        {
            _driver.FindElement(_femaleCheckbox).Click();
            return this;
        }

        public AccountCreation InputFirstName()
        {
            _driver.FindElement(_firstNamefield).SendKeys("Petya");
            return this;
        }

        public AccountCreation InputLasttName()
        {
            _driver.FindElement(_lastNamefield).SendKeys("Masha");
            return this;
        }

        public AccountCreation InputPassword()
        {
            _driver.FindElement(_passwordField).SendKeys("123456");
            return this;
        }

        public AccountCreation EmailInput()
        {
            _driver.FindElement(_fieldEmail).SendKeys("qwerty1224@mail.ru");
            return this;
        }

        public AccountCreation NewsletterCheckboxClick()
        {
            _driver.FindElement(_newsletterCheckbox).Click();
            return this;
        }

        public AccountCreation OffersCheckboxClick()
        {
            _driver.FindElement(_offersCheckbox).Click(); 
            return this;
        }

        public AccountCreation DayOfBirthScrollClick()
        {
            _driver.FindElement(_scrollDays).Click();
            _driver.FindElement(_scrollDays).SendKeys("8");
            _driver.FindElement(_scrollDays).SendKeys(Keys.Enter);
            return this;
        }

        public AccountCreation MonthOfBirthScrollClick()
        {
            _driver.FindElement(_scrolMonths).Click();
            _driver.FindElement(_scrolMonths).SendKeys("January");
            _driver.FindElement(_scrolMonths).SendKeys(Keys.Enter);
            return this;
        }

        public AccountCreation YearOfBirthChooseClick()
        {
            _driver.FindElement(_scrollYears).Click();
            _driver.FindElement(_scrollYears).SendKeys("1991");
            _driver.FindElement(_scrollYears).SendKeys(Keys.Enter);
            return this;
        }

        public AccountCreation ConfirmFirstName()
        {
            _driver.FindElement(_firstNameConfirmField).SendKeys("Petya");
            return this;
        }

        public AccountCreation ConfirmLasttName()
        {
            _driver.FindElement(_lastNameConfirmField).SendKeys("Masha");
            return this;
        }

        public AccountCreation CompanyNameField()
        {
            _driver.FindElement(_companyField).SendKeys("Google");
            return this;
        }

        public AccountCreation AddressLineFirstField()
        {
            _driver.FindElement(_addressField).SendKeys("Times Square 3");
            return this;
        }

        public AccountCreation AddressLineSecondField()
        {
            _driver.FindElement(_addressField2).SendKeys("141 appartment, 3 floor");
            return this;
        }

        public AccountCreation CityField()
        {
            _driver.FindElement(_cityField).SendKeys("New York");
            return this;
        }

        public AccountCreation StateScroll()
        {
            _driver.FindElement(_stateScroll).Click();
            _driver.FindElement(_stateScroll).SendKeys("Nevada");
            _driver.FindElement(_stateScroll).SendKeys(Keys.Enter);
            return this;
        }


        public AccountCreation PostalCodeField()
        {
            _driver.FindElement(_postcodeField).SendKeys("49033");
            return this;
        }

        public AccountCreation ChooseCountryScroll()
        {
            _driver.FindElement(_countryScroll).Click();
            _driver.FindElement(_countryScroll).SendKeys("unit");
            _driver.FindElement(_countryScroll).SendKeys(Keys.Enter);
            return this;
        }

        public AccountCreation OtherField()
        {
            _driver.FindElement(_otherField).SendKeys("Right direct approach");
            return this;
        }

        public AccountCreation HomePhoneField()
        {
            _driver.FindElement(_homePhoneField).SendKeys("22668877");
            return this;
        }

        public AccountCreation MobilePhoneField()
        {
            _driver.FindElement(_mobilePhoneField).SendKeys("380962707212");
            return this;
        }

        public AccountCreation Aliasield()
        {
            _driver.FindElement(_aliasField).SendKeys("Master");
            return this;
        }

        public MyAccount ClickRegistrationButton()
        {
            _driver.FindElement(_submitButton).Click();
            return new MyAccount(_driver);
        }
    }
}
