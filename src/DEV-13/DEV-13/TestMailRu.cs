using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

namespace DEV_13
{
    [TestClass]
    public class TestMailRu
    {
        HomePage homePage;
        AuthorizationPage autoPage;
        ErrorPage errorPage;
        string URL = "https://mail.ru";
        string userLogin;
        string userPassword;
        string password = "23.03.2017";
        string user = "tat-dev13@mail.ru";
        
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

 
        [DataSource("System.Data.OleDb",
       "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"F:\\AT\\currenttime\\src\\DEV-13\\NotValidLoginPassword.mdb\"",
       "Tb1",
       DataAccessMethod.Sequential)]
        [TestMethod()]
        public void TestNotValidInputLoginAndPassword_Chrome()
        {
            bool isValid = TestNotValidInputLoginAndPassword(new ChromeDriver());
            Assert.IsTrue(isValid);
        }

        [DataSource("System.Data.OleDb",
       "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"F:\\AT\\currenttime\\src\\DEV-13\\NotValidLoginPassword.mdb\"",
       "Tb1",
       DataAccessMethod.Sequential)]
        [TestMethod()]
        public void TestNotValidInputLoginAndPassword_Firefox()
        {
            bool isValid = TestNotValidInputLoginAndPassword(new FirefoxDriver());
            Assert.IsTrue(isValid);
        }



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

        public bool TestNotValidInputLoginAndPassword(IWebDriver driver)
        {
            userLogin = testContextInstance.DataRow["Login"].ToString();
            userPassword = testContextInstance.DataRow["Password"].ToString();
            using (driver)
            {
                driver.Navigate().GoToUrl(URL);
                autoPage = new AuthorizationPage(driver);
                autoPage.FillForm(userLogin, userPassword);
                errorPage = new ErrorPage(driver);
                return errorPage.IsErrorPage();
            }
        }
    }
}
