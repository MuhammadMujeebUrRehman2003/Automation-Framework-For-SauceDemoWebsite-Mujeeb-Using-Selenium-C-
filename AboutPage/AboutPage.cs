using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Project.Core;
using System.Threading;

namespace Project.AboutPage
{
    public class AboutPage : BasePage
    {  // Locators

        private By aboutTitle = By.CssSelector("h1.MuiTypography-h1");
        private By headeraboutTitle = By.CssSelector(".MuiTypography-root.MuiTypography-body2");
        private By headeraboutlinkTitle = By.XPath("//p[text()='Learn More']");
        private By CrossMuj = By.CssSelector("p.MuiTypography-body1");
        private By AboutParaTXT = By.CssSelector("p.MuiTypography-body2");
        private By SignupBTNTXT = By.CssSelector("button.MuiButton-containedAccentGreen");
        private By DemoBTNTXT = By.XPath("//button[normalize-space()='Book a demo']");
        private By MainBTNTXT = By.XPath("//button[normalize-space()='Learn more about integrations']");



        public void AboutMainTitle(string message2)
        {

            Thread.Sleep(15000);

            TakeScreenShot(Status.Pass, "About Page Title");
            Assert.AreEqual(message2, driver.FindElement(aboutTitle).Text);

        }


        public void GetHeaderAboutTitle(string message2)
        {

            Thread.Sleep(10000);

            Assert.AreEqual(message2, driver.FindElement(headeraboutTitle).Text);
            TakeScreenShot(Status.Pass, "Header About Title");

            Thread.Sleep(5000);

        }

        public void GetHeaderAboutLinkTitle(string message2)
        {
            Thread.Sleep(10000);

            Assert.AreEqual(message2, driver.FindElement(headeraboutlinkTitle).Text);
            TakeScreenShot(Status.Pass, "Header About Link Title");

        }

        public void GetClickHeaderAboutLinkTitle()
        {
            driver.FindElement(headeraboutlinkTitle).Click();
            TakeScreenShot(Status.Pass, "Click On Header About Link Title");


            Thread.Sleep(10000);
        }
        public void CrossIconClick(string message3)
        {

            Thread.Sleep(10000);

            driver.FindElement(CrossMuj).Click();
            TakeScreenShot(Status.Pass, "Click on Cross");

            Thread.Sleep(5000);

            Assert.AreEqual(message3, driver.FindElement(AboutParaTXT).Text);
            TakeScreenShot(Status.Pass, "Header About Link Title");


        }



        public void SIGNUPTXT(string message2)
        {

            Thread.Sleep(10000);

            Assert.AreEqual(message2, driver.FindElement(SignupBTNTXT).Text);
            TakeScreenShot(Status.Pass, "About Signup Button Text");


        }


        public void SIGNUPTXTClick(string message2)
        {

            Thread.Sleep(10000);

            Assert.AreEqual(message2, driver.FindElement(SignupBTNTXT).Text);
            TakeScreenShot(Status.Pass, "About Signup Button Text");


            Thread.Sleep(10000);

            driver.FindElement(SignupBTNTXT).Click();
            TakeScreenShot(Status.Pass, "Click About Signup Button Text");

        }

        public void DEMOBTNTXT(string message2)
        {
            Thread.Sleep(10000);

            Assert.AreEqual(message2, driver.FindElement(DemoBTNTXT).Text);
            TakeScreenShot(Status.Pass, "About Demo Button Text");

        }


        public void DEMOBTNTXTClick(string message2)
        {
            Thread.Sleep(10000);

            Assert.AreEqual(message2, driver.FindElement(DemoBTNTXT).Text);
            TakeScreenShot(Status.Pass, "About Demo Button Text");

            Thread.Sleep(5000);

            TakeScreenShot(Status.Pass, "About Demo Button Click");
            driver.FindElement(DemoBTNTXT).Click();

        }

        public void MainButtonText(string message3)
        {

            Thread.Sleep(10000);

            Assert.AreEqual(message3, driver.FindElement(MainBTNTXT).Text);
            TakeScreenShot(Status.Pass, "Main Button Text");


        }



        public void MainButtonTextClick(string message3)
        {
            Thread.Sleep(10000);

            Assert.AreEqual(message3, driver.FindElement(MainBTNTXT).Text);
            TakeScreenShot(Status.Pass, "Main Button Text");

            Thread.Sleep(10000);

            driver.FindElement(MainBTNTXT).Click();
            TakeScreenShot(Status.Pass, "Click On Main Button Text");

        }


    }
}
