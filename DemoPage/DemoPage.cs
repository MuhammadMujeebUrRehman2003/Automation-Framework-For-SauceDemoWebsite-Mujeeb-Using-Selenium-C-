using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Project.Core;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Project.DemoPage
{
    public class DemoPage : BasePage
    {

        // Locators

        private By ExperTalks = By.XPath("//h2[normalize-space()='Talk to an Expert']");

        // Get home page product title




        public void DemoToExpertTalks(string message3)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));

            // Wait until new tab opens
            wait.Until(d => d.WindowHandles.Count > 1);

            // Switch to the new window
            driver.SwitchTo().Window(driver.WindowHandles.Last());

            // Wait until the element is visible
            Assert.AreEqual(message3, driver.FindElement(ExperTalks).Text);
            TakeScreenShot(Status.Pass, "About Demo Button Text To Expert Talks Text");


        }









    }
}
