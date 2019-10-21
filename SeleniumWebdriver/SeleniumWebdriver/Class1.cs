using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumWebdriver
{
   [TestFixture]
    public class Class1 : TestBase
    {
        [Test]
        public void verifyValidLogin()
        {
            try
            {
                driver.Url = "C:\\Users\\Admin\\source\\repos\\devopsFrontendLogin\\index.html";
                driver.FindElement(By.Id("name")).SendKeys("anushka");
                driver.FindElement(By.Id("password")).SendKeys("anushka");
                driver.FindElement(By.Id("submitForm")).Click();
                IAlert alert = driver.SwitchTo().Alert();
                Assert.That(alert.Text, Does.Match("User successfully logged in"));
                alert.Accept();
            }
            catch (NoAlertPresentException)
            {
                
            }
        }

        
        [Test]
        public void verifyInvalidLogin()
        {
            try
            {
              driver.Url = "C:\\Users\\Admin\\source\\repos\\devopsFrontendLogin\\index.html";
              driver.FindElement(By.Id("name")).SendKeys("anushka123");
              driver.FindElement(By.Id("password")).SendKeys("anushka123");
              driver.FindElement(By.Id("submitForm")).Click();
              IAlert alert = driver.SwitchTo().Alert();
              Assert.That(alert.Text, Does.Match("Incorrect username or password"));
              alert.Accept();
            }
            catch (NoAlertPresentException)
            {

            }
        }
    }
}
