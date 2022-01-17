using OpenQA.Selenium;
using System;

//Sheremet

namespace C_Sharp_HW19.PageObjects

{
    public class ImproveAddresses : Header
    {
        public ImproveAddresses(IWebDriver driver)
        {
            _driver = driver;
        }

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
        private readonly By _additionalInfo = By.XPath("//input[@id='addinfo']");
        private readonly By _submitButton = By.XPath("//button[@id='submitAccount']/span");
        private readonly By _alias = By.XPath("//input[@id='alias']");

        public ImproveAddresses ConfirmFirstName()
        {
            _driver.FindElement(_firstNameConfirmField).SendKeys("Petya");
            return this;
        }

        public ImproveAddresses ConfirmLasttName()
        {
            _driver.FindElement(_lastNameConfirmField).SendKeys("Masha");
            return this;
        }

        public ImproveAddresses CompanyNameField()
        {
            _driver.FindElement(_companyField).SendKeys("Google");
            return this;
        }

        public ImproveAddresses AddressLineFirstField()
        {
            _driver.FindElement(_addressField).SendKeys("Times Square 3");
            return this;
        }

        public ImproveAddresses AddressLineSecondField()
        {
            _driver.FindElement(_addressField2).SendKeys("141 appartment, 3 floor");
            return this;
        }

        public ImproveAddresses CityField()
        {
            _driver.FindElement(_cityField).SendKeys("New York");
            return this;
        }

        public ImproveAddresses StateScroll()
        {
            _driver.FindElement(_stateScroll).Click();
            _driver.FindElement(_stateScroll).SendKeys("Nevada");
            _driver.FindElement(_stateScroll).SendKeys(Keys.Enter);
            return this;
        }


        public ImproveAddresses PostalCodeField()
        {
            _driver.FindElement(_postcodeField).SendKeys("49033");
            return this;
        }

        public ImproveAddresses ChooseCountryScroll()
        {
            _driver.FindElement(_countryScroll).Click();
            _driver.FindElement(_countryScroll).SendKeys("unit");
            _driver.FindElement(_countryScroll).SendKeys(Keys.Enter);
            return this;
        }

        public ImproveAddresses OtherField()
        {
            _driver.FindElement(_otherField).SendKeys("Right direct approach");
            return this;
        }

        public ImproveAddresses HomePhoneField()
        {
            _driver.FindElement(_homePhoneField).SendKeys("22668877");
            return this;
        }

        public ImproveAddresses MobilePhoneField()
        {
            _driver.FindElement(_mobilePhoneField).SendKeys("380962707212");
            return this;
        }

        public ImproveAddresses Aliasield()
        {
            _driver.FindElement(_alias).SendKeys("Master");
            return this;
        }

        public MyAccount ClickRegistrationButton()
        {
            _driver.FindElement(_submitButton).Click();
            return new MyAccount(_driver);
        }


    }
}
