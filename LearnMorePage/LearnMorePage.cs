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

namespace Project.LearnMorePage
{
    public class LearnMorePage : BasePage
    {

        private By learnMoremaintitle = By.CssSelector("h2.MuiTypography-h3");



        public void LearnMoreMainTitle(string message2)
        {

            Assert.AreEqual(message2, driver.FindElement(learnMoremaintitle).Text);
            TakeScreenShot(Status.Pass, "Learn More Main Title");



        }


    }
}
