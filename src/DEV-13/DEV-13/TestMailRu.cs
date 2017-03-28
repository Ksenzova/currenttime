using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace DEV_13
{
    [TestClass]
    public class TestMailRu
    {
        IWebDriver driver;
        HomePage homePage;
        AuthorizationPage autoPage;
        ErrorPage errorPage;
        string URL = "https://mail.ru";
        string password = "23.03.2017";
        string user = "tat-dev13@mail.ru";

        [TestMethod]
        public void TestValidInput_Chrome()
        {
           bool IsValid = TestValidInput(new ChromeDriver());
           Assert.IsTrue(IsValid);
        }

        [TestMethod]
        public void TestValidInput_Firefox()
        {
            bool IsValid = TestValidInput(new FirefoxDriver());
            Assert.IsTrue(IsValid);
        }

        [TestMethod]
        public void TestValidInput_Opera()
        {
            bool IsValid = TestValidInput(new OperaDriver());
            Assert.IsTrue(IsValid);
        }
        
        // Empty input password
        [TestMethod]
        public void TestEmptyInputPassword_Chrome()
        {
            bool IsValid =TestEmptyInputPassword(new ChromeDriver());
            Assert.IsTrue(IsValid);
        }

        [TestMethod]
        public void TestEmptyInputPassword_Firefox()
        {
            bool IsValid = TestEmptyInputPassword(new FirefoxDriver());
            Assert.IsTrue(IsValid);
        }

        [TestMethod]
        public void TestEmptyInputPassword_Opera()
        {
            bool IsValid = TestEmptyInputPassword(new OperaDriver());
            Assert.IsTrue(IsValid);
        }
           

        // Empty input password and login
        [TestMethod]
        public void TestEmptyInput_Chrome()
        {
            bool IsValid = TestEmptyInput(new ChromeDriver());
            Assert.IsTrue(IsValid);
        }

        [TestMethod]
        public void TestEmptyInput_Firefox()
        {
            bool IsValid = TestEmptyInput(new FirefoxDriver());
            Assert.IsTrue(IsValid);
        }

        [TestMethod]
        public void TestEmptyInput_Opera()
        {
            bool IsValid = TestEmptyInput(new OperaDriver());
            Assert.IsTrue(IsValid);
        }
            

        // Error input password
        [TestMethod]
        public void TestErrorInputPassword_Chrome()
        {
            bool IsValid = TestErrorInputPassword(new ChromeDriver());
            Assert.IsTrue(IsValid);
        }

        [TestMethod]
        public void TestErrorInputPassword_Firefox()
        {
            bool IsValid = TestErrorInputPassword(new FirefoxDriver());
            Assert.IsTrue(IsValid);
        }

        [TestMethod]
        public void TestErrorInputPassword_Opera()
        {
            bool IsValid = TestErrorInputPassword(new OperaDriver());
            Assert.IsTrue(IsValid);
        }

        // Error input login
        [TestMethod]
        public void TestNotValidLogin_Chrome()
        {
            bool IsValid = TestNotValidLogin(new ChromeDriver()); 
            Assert.IsTrue(IsValid);
        }

        [TestMethod]
        public void TestNotvalidLogin_Firefox()
        {
            bool IsValid = TestNotValidLogin(new FirefoxDriver());
            Assert.IsTrue(IsValid);
        }

        [TestMethod]
        public void TestNotValidLogin_Opera()
        {
            bool IsValid = TestNotValidLogin(new OperaDriver());
            Assert.IsTrue(IsValid);
        }

        public bool TestNotValidLogin(IWebDriver driver)
        {
            using (driver)
            {
                driver.Navigate().GoToUrl(URL);
                autoPage = new AuthorizationPage(driver);
                autoPage.FillForm("123", password);
                errorPage = new ErrorPage(driver);
                return errorPage.IsErrorPage();
            }
        }

        public bool TestErrorInputPassword(IWebDriver driver)
        {
            using (driver)
            {
                driver.Navigate().GoToUrl(URL);
                autoPage = new AuthorizationPage(driver);
                autoPage.FillForm(user, "23.03.2016");
                errorPage = new ErrorPage(driver);
                return errorPage.IsErrorPage();
            }
        }

        public bool TestEmptyInput(IWebDriver driver)
        {
            using (driver)
            {
                driver.Navigate().GoToUrl(URL);
                autoPage = new AuthorizationPage(driver);
                autoPage.FillForm("", "");
                errorPage = new ErrorPage(driver);
                return errorPage.IsErrorPage();
            }
        }

        public bool TestEmptyInputPassword(IWebDriver driver)
        {
            using (driver)
            {
                driver.Navigate().GoToUrl(URL);
                autoPage = new AuthorizationPage(driver);
                autoPage.FillForm(user, "");
                errorPage = new ErrorPage(driver);
                return errorPage.IsErrorPage();
            }
        }

        public bool TestValidInput(IWebDriver driver)
        {
            using (driver)
            {
                driver.Navigate().GoToUrl(URL);
                autoPage = new AuthorizationPage(driver);
                autoPage.FillForm(user, password);
                homePage = new HomePage(driver);
                return homePage.IsHomePage();
            }
        }
    }
}
