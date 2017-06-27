using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace TestLogin.Pages
{
    class AuthorizationPage
    {
        public const string UserNameField = "//*[text()='user_login']::following-sibling";
        public const string PasswordTextField = "//*[text()='Password']::following-sibling";
        public const string LoginButton = "//*[@id='wp-submit']";

        [FindsBy(How = How.Name, Using = UserNameField)]
        public IWebElement userNameTextField;
        [FindsBy(How = How.Name, Using = PasswordTextField)]
        public IWebElement passwordTextField;
        [FindsBy(How = How.Id, Using = LoginButton)]
        public IWebElement loginButton;

        private IWebDriver driver;

        public AuthorizationPage(IWebDriver Driver)
        {
            this.driver = Driver;
            PageFactory.InitElements(driver, this);
        }

        public bool IsAuthorizationPage()
        {
            bool flag = true;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            try
            {
                wait.Until(ExpectedConditions.ElementExists(By.Id(LoginButton)));
            }
            catch (Exception)
            {
                flag = false;
            }
            return flag;
        }

        public void SetUserName(string UserName)
        {
            this.userNameTextField.Clear();
            this.userNameTextField.SendKeys(UserName);
        }

        public void SetPassword(string Password)
        {
            this.passwordTextField.Clear();
            this.passwordTextField.SendKeys(Password);
        }

        public void ClickLogin()
        {
            this.loginButton.Click();
        }
        public void FillForm(string strUsername, string strPassword)
        {
            this.SetUserName(strUsername);
            this.SetPassword(strPassword);
            this.ClickLogin();
        }
    }
}
