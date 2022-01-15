using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace C_Sharp_HW19.PageObject
{
    public class OurStores : Footer
    {
        public OurStores(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}