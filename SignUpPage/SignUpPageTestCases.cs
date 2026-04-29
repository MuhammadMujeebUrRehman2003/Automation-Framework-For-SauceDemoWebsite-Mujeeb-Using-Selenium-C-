using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.BrowsingContext;
using Project.AboutPage;
using Project.Core;
using Project.HomePage;
using Project.LoginPage;
using Project.SignUpPage;
using System;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Windows.Forms;

namespace Project.SignUpPage
{
    [TestClass]
    public class SignUpPageTestCases : ExtentReport
    {
        BasePage basePage = new BasePage();
        LoginPage.LoginPage loginPage = new LoginPage.LoginPage();
        HomePage.HomePage homePage = new HomePage.HomePage();
        SideBarItems.SideBarItems sidebaritems = new SideBarItems.SideBarItems();
        AboutPage.AboutPage aboutPage = new AboutPage.AboutPage();
        SignUpPage signuppage = new SignUpPage();

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
"Data.xml", "ClickOnAboutPageSignUpButton", DataAccessMethod.Sequential)]
        public void ClickOnAboutPageSignUpButton()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message1 = TestContext.DataRow["message1"].ToString();
            string message2 = TestContext.DataRow["message2"].ToString();
            string message3 = TestContext.DataRow["message3"].ToString();

            exChildTest = exParentTest.CreateNode("Login");
            loginPage.Login(url, username, password);

            exChildTest = exParentTest.CreateNode("Assert The Home Page product Label");
            homePage.productlabel(message1);

            exChildTest = exParentTest.CreateNode("Click On Sidebar About Link");
            sidebaritems.AboutClick();

            exChildTest = exParentTest.CreateNode("Click On Sign up of free");
            aboutPage.SIGNUPTXTClick(message2);

            exChildTest = exParentTest.CreateNode("Assert Start testing in minutes");
            signuppage.SignupToRestart(message3);
        }


    }
}
