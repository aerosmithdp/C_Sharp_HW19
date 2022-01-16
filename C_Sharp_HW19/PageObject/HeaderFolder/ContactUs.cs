using OpenQA.Selenium;
using System;

//Created by Oleg Khizhnyi
namespace C_Sharp_HW19.PageObjects
{
    public class ContactUs : Header
    {
        public ContactUs(IWebDriver driver)
        {
            _driver = driver;
        }

        private readonly By _messageField = By.XPath("//textarea[@id='message']");
        private readonly By _subjectHeadingButton = By.XPath("//select[@id='id_contact']");
        private readonly By _emailAddressField = By.XPath("//input[@id='email']");
        private readonly By _orderReferenceField = By.XPath("//input[@id='id_order']");
        private readonly By _chooseFileButton = By.XPath("//input[@id='fileUpload']");
        private readonly By _sendButton = By.XPath("//button[@id='submitMessage']/span");

        public ContactUs EnterTextMessageField()
        {
            _driver.FindElement(_messageField).SendKeys("help! help me!");
            return this;
        }
        public ContactUs ClickSubjectHeadingButton()
        {
            _driver.FindElement(_subjectHeadingButton).Click();
            return this;
        }
        public ContactUs ClickSubjectHeadingButtonChooseCustomerService()
        {
            _driver.FindElement(_subjectHeadingButton).Click();
            _driver.FindElement(_subjectHeadingButton).SendKeys("Cu");
            _driver.FindElement(_subjectHeadingButton).SendKeys(Keys.Enter);
            return this;
        }
        public ContactUs ClickEmailAddressFieldEnterText()
        {
            _driver.FindElement(_emailAddressField).SendKeys("helpme@gmail.com");
            return this;
        }
        public ContactUs ClickOrderReferenceFieldEnterText()
        {
            _driver.FindElement(_orderReferenceField).SendKeys("123456789");
            return this;
        }
        public ContactUs ClickChooseFileButton()
        {
            _driver.FindElement(_chooseFileButton).Click();
            _driver.FindElement(_chooseFileButton).SendKeys(Keys.Escape);
            return this;
        }
        public ContactUs ClickSendButton()
        {
            _driver.FindElement(_sendButton).Click();
            return this;
        }



    }
}
