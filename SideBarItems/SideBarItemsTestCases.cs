using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.AboutPage;
using Project.Core;
using Project.HomePage;
using Project.LoginPage;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.BrowsingContext;
using System;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Windows.Forms;


namespace Project.SideBarItems
{
    public class SideBarItemsTestCases : ExtentReport
    {
        [TestClass]
        public class HomePageTestCases : ExtentReport
        {
            // Base page for driver initialization
            BasePage basePage = new BasePage();
            LoginPage.LoginPage loginPage = new LoginPage.LoginPage();
            HomePage.HomePage homePage = new HomePage.HomePage();
            SideBarItems sidebaritems = new SideBarItems();


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

            // Home page sidebar test
            [TestMethod]
            [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
                        "|DataDirectory|\\Data.xml",
                        "SideBarItems",
                        DataAccessMethod.Sequential)]
            public void SideBarItems()
            {
                string url = TestContext.DataRow["url"].ToString();
                string username = TestContext.DataRow["username"].ToString();
                string password = TestContext.DataRow["password"].ToString();
                string message1 = TestContext.DataRow["message1"].ToString();
                string message2 = TestContext.DataRow["message2"].ToString();

                Thread.Sleep(5000);
                exChildTest = exParentTest.CreateNode("Login");
                loginPage.Login(url, username, password);

                exChildTest = exParentTest.CreateNode("Assert The Home Page product Label");
                homePage.productlabel(message1);

                exChildTest = exParentTest.CreateNode("Search All Items Text In Sidebar");
                sidebaritems.HomeSidebar(message2);
            }

        }


    }


}