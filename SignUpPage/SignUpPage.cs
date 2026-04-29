using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter.Config;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Project.Core;
using SeleniumExtras.WaitHelpers; // <-- THIS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Project.SignUpPage
{
    public class SignUpPage : BasePage
    {  // Locators

        private By Signuptorestart = By.Id("title");


        public void SignupToRestart(string message3)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));

            // Wait until new tab opens
            wait.Until(d => d.WindowHandles.Count > 1);

            // Switch to the new window
            driver.SwitchTo().Window(driver.WindowHandles.Last());

            // Wait until the element is visible
            Assert.AreEqual(message3, driver.FindElement(Signuptorestart).Text);

            TakeScreenShot(Status.Pass, "About SignUp Button Text To Restart Text");





        }


    }
}


