using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class UntitledTestCase
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.google.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheUntitledTestCaseTest()
        {
            driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/index.htm");
            driver.FindElement(By.Name("username")).Clear();
            driver.FindElement(By.Name("username")).SendKeys("jelena");
            driver.FindElement(By.Name("password")).Click();
            driver.FindElement(By.Name("password")).Clear();
            driver.FindElement(By.Name("password")).SendKeys("jelena123");
            driver.FindElement(By.XPath("//input[@value='Log In']")).Click();
            driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/overview.htm");
            driver.FindElement(By.LinkText("About Us")).Click();
            driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/about.htm");
            driver.FindElement(By.LinkText("Services")).Click();
            driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/services.htm");
            driver.FindElement(By.LinkText("Products")).Click();
            driver.Navigate().GoToUrl("https://www.parasoft.com/products/");
            driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/services.htm");
            driver.FindElement(By.LinkText("Request Loan")).Click();
            driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/requestloan.htm");
            driver.FindElement(By.LinkText("Update Contact Info")).Click();
            driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/updateprofile.htm");
            driver.FindElement(By.Id("customer.address.street")).Click();
            driver.FindElement(By.Id("customer.address.street")).Clear();
            driver.FindElement(By.Id("customer.address.street")).SendKeys("ulica 12");
            driver.FindElement(By.XPath("//input[@value='Update Profile']")).Click();
            driver.FindElement(By.LinkText("Log Out")).Click();
            driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/index.htm?ConnType=JDBC");
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
