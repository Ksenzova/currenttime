using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace DEV_13
{
    class HomePage
    {       
        public const string IncommingMessanges = "//*[contains(text(),'Входящие')]";
        private IWebDriver driver;

        public HomePage(IWebDriver Driver)
        {
            this.driver = Driver;
        }

        public bool IsHomePage()
        {
            bool flag = true;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            try
            {
                wait.Until(driver => driver.FindElement(By.XPath(IncommingMessanges)));
            }
            catch (Exception)
            {
                flag = false;
            }
            return flag;
        }
    }
}
