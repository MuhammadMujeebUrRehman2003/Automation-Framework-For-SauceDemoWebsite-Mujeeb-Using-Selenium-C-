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

namespace Project.SideBarItems
{
    public class SideBarItems : BasePage
    {

        private By allitemstxt = By.Id("inventory_sidebar_link");
        private By burgerMenu = By.Id("react-burger-menu-btn");
        private By aboutLink = By.Id("about_sidebar_link");
        private By logoutlink = By.Id("logout_sidebar_link");




        public void HomeSidebar(string message2)
        {


            driver.FindElement(burgerMenu).Click();
            TakeScreenShot(Status.Pass, "Click on Sidebar Button");

            Thread.Sleep(5000);

            Assert.AreEqual(message2, driver.FindElement(allitemstxt).Text);
            TakeScreenShot(Status.Pass, "Sidebar Link Text");

            Thread.Sleep(5000);
        }

        public void AboutClick()
        {

            driver.FindElement(burgerMenu).Click();
            TakeScreenShot(Status.Pass, "Click on Sidebar Button");

            Thread.Sleep(5000);

            driver.FindElement(aboutLink).Click();
            TakeScreenShot(Status.Pass, "Click on Sidebar Link Text");

            Thread.Sleep(5000);

        }


        public void LogouttClick()
        {
            driver.FindElement(burgerMenu).Click();
            TakeScreenShot(Status.Pass, "Click on Sidebar Button");

            Thread.Sleep(5000);

            driver.FindElement(logoutlink).Click();
            TakeScreenShot(Status.Pass, "Click on Sidebar Link Text");

            Thread.Sleep(5000);

        }
    }
}
