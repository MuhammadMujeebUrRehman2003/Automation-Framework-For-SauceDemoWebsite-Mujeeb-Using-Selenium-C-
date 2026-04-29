using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.BrowsingContext;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AventStack.ExtentReports.Reporter.Config;

namespace Project.SocialMedia
{
    public class SocialMediaPage : BasePage
    {


        public void ClickSocialMedia(string locator, string web)
        {

            Thread.Sleep(15000);

            driver.FindElement(By.CssSelector(locator)).Click();
            TakeScreenShot(Status.Pass, "Click on Social Media Icon");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));

            // Wait until new tab opens
            wait.Until(d => d.WindowHandles.Count > 1);

            // Switch to the new window
            driver.SwitchTo().Window(driver.WindowHandles.Last());


            Thread.Sleep(5000);


            Assert.IsTrue(driver.Url.Contains(web));
            TakeScreenShot(Status.Pass, "Is It Contains Url");
        }




    }
}
