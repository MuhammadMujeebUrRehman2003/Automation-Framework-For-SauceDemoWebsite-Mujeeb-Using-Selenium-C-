using AventStack.ExtentReports;
using Project.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project.LoginPage
{
    public class LoginPage : BasePage
    {
        #region Locators
        public static By usernameTXT = By.Id("user-name");
        public static By passwordTXT = By.Id("password");
        public static By LoginBTN = By.Id("login-button");
        public static By ProductLBL = By.ClassName("app_logo");
        public static By ErrorMessage = By.CssSelector("h3[data-test='error']");
        #endregion

        #region Methods
        public void Login(string url, string username, string password)
        {
            driver.Navigate().GoToUrl(url);
            driver.Url = url;
            TakeScreenShot(Status.Pass, "Enter URL");
            driver.FindElement(usernameTXT).SendKeys(username);
            TakeScreenShot(Status.Pass, "Enter Username");
            driver.FindElement(passwordTXT).SendKeys(password);
            TakeScreenShot(Status.Pass, "Enter Password");
            driver.FindElement(LoginBTN).Click();
            TakeScreenShot(Status.Pass, "Click on Login Button");
            Thread.Sleep(5000);
        }

        #endregion
    }
}
