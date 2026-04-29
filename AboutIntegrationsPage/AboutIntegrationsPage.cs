using AventStack.ExtentReports;
using Project.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using SeleniumExtras.WaitHelpers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace Project.AboutIntegrationsPage
{
    public class AboutIntegrationsPage : BasePage
    {


        private By TextAfterClickOnMainBTNTXT = By.XPath("//h2[normalize-space()='Sauce Labs integrates with the best tools for CI/CD, automated testing, team collaboration, and more']");


        public void TextAfterClickOnMainButtonTXT(string message4)
        {
            Thread.Sleep(5000);

            TakeScreenShot(Status.Pass, "Text After Click On Main Button Text");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            // Wait until new tab opens
            wait.Until(d => d.WindowHandles.Count > 1);

            // Switch to new tab
            driver.SwitchTo().Window(driver.WindowHandles.Last());

            // Wait for the element to appear

            Assert.AreEqual(message4, driver.FindElement(TextAfterClickOnMainBTNTXT).Text);


        }

    }
}
