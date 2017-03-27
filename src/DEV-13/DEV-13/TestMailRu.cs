using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

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
        string user = "tat-de13@mail.ru";

        [TestMethod]
        public void TestValidInput_Chrome()
        {
            driver = new ChromeDriver();
            TestValidInput(driver);
        }

        [TestMethod]
        public void TestValidInput_Firefox()
        {
            driver = new FirefoxDriver();
            TestValidInput(driver);
        }

        [TestMethod]
        public void TestValidInput_Opera()
        {
            driver = new OperaDriver();
            TestValidInput(driver);
        }
        
        // Empty input password
        [TestMethod]
        public void TestEmptyInputPassword_Chrome()
        {
            driver = new ChromeDriver();
            TestEmptyInputPassword(driver);
        }

        [TestMethod]
        public void TestEmptyInputPassword_Firefox()
        {
            driver = new FirefoxDriver();
            TestEmptyInputPassword(driver);
        }

        [TestMethod]
        public void TestEmptyInputPassword_Opera()
        {
            driver = new OperaDriver();
            TestEmptyInputPassword(driver);
        }
           

        // Empty input password and login
        [TestMethod]
        public void TestEmptyInput_Chrome()
        {
            driver = new ChromeDriver();
            TestEmptyInput(driver);
        }

        [TestMethod]
        public void TestEmptyInput_Firefox()
        {
            driver = new FirefoxDriver();
            TestEmptyInput(driver);
        }

        [TestMethod]
        public void TestEmptyInput_Opera()
        {
            driver = new OperaDriver();
            TestEmptyInput(driver);
        }
            

        // Error input password
        [TestMethod]
        public void TestErrorInputPassword_Chrome()
        {
            driver = new ChromeDriver();
            TestErrorInputPassword(driver);
        }

        [TestMethod]
        public void TestErrorInputPassword_Firefox()
        {
            driver = new FirefoxDriver();
            TestErrorInputPassword(driver);
        }

        [TestMethod]
        public void TestErrorInputPassword_Opera()
        {
            driver = new OperaDriver();
            TestErrorInputPassword(driver);
        }

        // Error input login
        [TestMethod]
        public void TestNotValidLogin_Chrome()
        {
            driver = new ChromeDriver();
            TestNotValidLogin(driver);
        }

        [TestMethod]
        public void TestNotvalidLogin_Firefox()
        {
            driver = new FirefoxDriver();
            TestNotValidLogin(driver);
        }

        [TestMethod]
        public void TestNotValidLogin_Opera()
        {
            driver = new OperaDriver();
            TestNotValidLogin(driver);
        }

        public void TestNotValidLogin(IWebDriver driver)
        {
            using (driver)
            {
                driver.Navigate().GoToUrl(URL);
                autoPage = new AuthorizationPage(driver);
                autoPage.FillForm("123", password);
                errorPage = new ErrorPage(driver);
                errorPage.FindNeedElement();
            }
        }

        public void TestErrorInputPassword(IWebDriver driver)
        {
            using (driver)
            {
                driver.Navigate().GoToUrl(URL);
                autoPage = new AuthorizationPage(driver);
                autoPage.FillForm(user, "23.03.2016");
                errorPage = new ErrorPage(driver);
                errorPage.FindNeedElement();
            }
        }

        public void TestEmptyInput(IWebDriver driver)
        {
            using (driver)
            {
                driver.Navigate().GoToUrl(URL);
                autoPage = new AuthorizationPage(driver);
                autoPage.FillForm("", "");
                errorPage = new ErrorPage(driver);
                errorPage.FindNeedElement();
            }
        }

        public void TestEmptyInputPassword(IWebDriver driver)
        {
            using (driver)
            {
                driver.Navigate().GoToUrl(URL);
                autoPage = new AuthorizationPage(driver);
                autoPage.FillForm(user, "");
                errorPage = new ErrorPage(driver);
                errorPage.FindNeedElement();
            }
        }

        public void TestValidInput(IWebDriver driver)
        {
            using (driver)
            {
                driver.Navigate().GoToUrl(URL);
                driver.Manage().Timeouts().ImplicitlyWait(timeToWait);
                autoPage = new AuthorizationPage(driver);
                autoPage.FillForm(user, password);
                homePage = new HomePage(driver);
                homePage.FindNeedElement();
                Assert.IsTrue(driver.PageSource.Contains("Входящие"));
            }
        }

    }
}
