using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver
{
    public class TestBase
    {

        protected IWebDriver driver;
        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("C:\\Users\\Admin\\Downloads\\chromedriver_win32");
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Quit();
        }

    }
}
