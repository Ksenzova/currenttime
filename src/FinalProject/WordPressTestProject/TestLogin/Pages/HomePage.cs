using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace FinalProject
{
    /// <summary>
    /// Describe Home page
    /// </summary>
    class HomePage
    {
        public IWebDriver Driver { get; private set; }
        protected const string Domain = @"http://localhost:8080/";

        private WebDriverWait wait;

        public HomePage(IWebDriver driver)
        {
            this.Driver = driver;
            driver.Navigate().GoToUrl(Domain);
        }

        public bool IsHomePage()
        {
            bool isHomePage = true;
            try
            {
                wait.Until(ExpectedConditions.ElementIsVisible(
                    By.XPath(@"//*[@id='welcome-panel']")));
            }
            catch (TimeoutException)
            {
                isHomePage = false;
            }
            return isHomePage;
        }
    }
}
