using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_13
{
    class ErrorPage
    {
        IWebDriver driver;
        By errorPage = By.XPath("//*[contains(text(),'Вход')]");
        public ErrorPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void FindNeedElement()
        {
            driver.FindElement(errorPage);
        }
    }
}
