using System;
using OpenQA.Selenium;

//Created by Oleg Khizhnyi
namespace C_Sharp_HW19.PageObjects
{
    public class Tops : Header
    {
        public Tops(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
