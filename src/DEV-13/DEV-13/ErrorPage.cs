using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_13
{
    class ErrorPage
    {
        private IWebDriver driver;
        public const string IncommingMessanges = "//*[contains(text(),'Вход')]";

        [FindsBy(How = How.XPath, Using = IncommingMessanges)]
        public IWebElement incomingingMessages;

        public ErrorPage(IWebDriver Driver)
        {
            this.driver = Driver;
            PageFactory.InitElements(driver, this);
        }

        public bool IsErrorPage()
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
