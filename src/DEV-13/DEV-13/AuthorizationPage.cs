using OpenQA.Selenium;

namespace DEV_13
{
    class AuthorizationPage
    {
        By userName = By.Id("mailbox__login");
        By password = By.Id("mailbox__password");
        By loginButton = By.Id("mailbox__auth__button");

        private IWebDriver driver;

        public AuthorizationPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void SetUserName(string UserName)
        {
            driver.FindElement(userName).SendKeys(UserName);
        }

        public void SetPassword (string Password)
        {
            driver.FindElement(password).SendKeys(Password);
        }

        public void ClickLogin()
        {
            driver.FindElement(loginButton).Click();
        }
        public void FillForm(string strUsername, string strPassword)
        {
            this.SetUserName(strUsername);
            this.SetPassword(strPassword);
            this.ClickLogin();
        }

    }
}
