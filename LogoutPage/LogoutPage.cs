using AventStack.ExtentReports;
using Project.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Project.LogoutPage
{
    public class LogoutPage : BasePage
    {

        private By relogin = By.ClassName("login_logo");


        public void GetLoginTitle(string message2)
        {
            Assert.AreEqual(message2, driver.FindElement(relogin).Text);
            TakeScreenShot(Status.Pass, "LogOut Title");

        }


    }
}
