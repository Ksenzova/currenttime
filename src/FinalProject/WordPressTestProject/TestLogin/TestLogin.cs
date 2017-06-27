using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalProject;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestLogin.Pages;

namespace TestLogin
{
    [TestClass]
    public class LoginPageTests
    {
        HomePage homePage;
        AuthorizationPage loginPage;
        string userLogin;
        string userPassword;

        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }


        [DataSource("System.Data.OleDb",
       "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"F:\\AT\\currenttime\\src\\FinalProject\\LoginPassword.mdb\"",
       "Tb1",
       DataAccessMethod.Sequential)]
        [TestMethod]
        public void LoginPageValidLogin()
        {
            userLogin = testContextInstance.DataRow["Login"].ToString();
            userPassword = testContextInstance.DataRow["Password"].ToString();
            using (IWebDriver driver = new ChromeDriver())
            {
                homePage = new HomePage(driver);
                loginPage = new AuthorizationPage(driver);
                loginPage.FillForm(userLogin, userPassword);
                Assert.IsTrue(homePage.IsHomePage());
            }
        }



        [DataSource("System.Data.OleDb",
       "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"F:\\AT\\currenttime\\src\\FinalProject\\LoginPassword.mdb\"",
       "Tb2",
       DataAccessMethod.Sequential)]
        [TestMethod]
        public void LoginPageNotValidLogin()
        {
            userLogin = testContextInstance.DataRow["Login"].ToString();
            userPassword = testContextInstance.DataRow["Password"].ToString();
            using (IWebDriver driver = new ChromeDriver())
            {
                homePage = new HomePage(driver);
                loginPage = new AuthorizationPage(driver);
                loginPage.FillForm(userLogin, userPassword);
                Assert.IsFalse(homePage.IsHomePage());
            }
        }
    }
}
