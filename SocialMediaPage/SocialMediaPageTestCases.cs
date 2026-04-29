using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.BrowsingContext;
using Project.AboutPage;
using Project.Core;
using Project.HomePage;
using Project.LoginPage;
using Project.SocialMedia;
using Project.SocialMediaPageTestCases;
using System;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Windows.Forms;

namespace Project.SocialMediaPageTestCases
{
    [TestClass]
    public class SocialMediaPageTestCases : ExtentReport
    {
        // Base page for driver initialization
        BasePage basePage = new BasePage();
        LoginPage.LoginPage loginPage = new LoginPage.LoginPage();
        HomePage.HomePage homePage = new HomePage.HomePage();
        SocialMediaPage socialmediapage = new SocialMediaPage();

        // Page objects



        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void Setup()
        {

            basePage.SeleniumInit();
            exParentTest = extentReports.CreateTest(TestContext.TestName);
        }
        [TestCleanup]
        public void TearDown()
        {
            basePage.DriverClose();
            extentReports.Flush();

        }


        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "|DataDirectory|\\Data.xml",
            "SocialMedia",
            DataAccessMethod.Sequential)]
        public void SocialMedia()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message1 = TestContext.DataRow["message"].ToString();
            string locator = TestContext.DataRow["locator"].ToString();
            string web = TestContext.DataRow["web"].ToString();

            Thread.Sleep(5000);
            exChildTest = exParentTest.CreateNode("Login");
            loginPage.Login(url, username, password);

            exChildTest = exParentTest.CreateNode("Assert The Home Page product Label");
            homePage.productlabel(message1);

            exChildTest = exParentTest.CreateNode("Click On Social Media Icon");
            socialmediapage.ClickSocialMedia(locator, web);


        }
    }
}
