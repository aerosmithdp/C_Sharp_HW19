﻿using OpenQA.Selenium;
using System;


namespace C_Sharp_HW19.PageObjects

{
    public class MyAddresses : Header
    {
        public MyAddresses(IWebDriver driver)
        {
            _driver = driver;
        }

    }
}