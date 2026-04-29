using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project.LogoutPage
{
    [TestClass]
    public class LogoutPageTestCases : ExtentReport
    {
        BasePage basePage = new BasePage();
        LoginPage.LoginPage loginPage = new LoginPage.LoginPage();
        HomePage.HomePage homePage = new HomePage.HomePage();
        AboutPage.AboutPage aboutPage = new AboutPage.AboutPage();
        SideBarItems.SideBarItems sidebaritems = new SideBarItems.SideBarItems();
        LogoutPage logoutPage = new LogoutPage();
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

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "Logout", DataAccessMethod.Sequential)]

        public void Logout()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message1 = TestContext.DataRow["message1"].ToString();
            string message2 = TestContext.DataRow["message2"].ToString();

            exChildTest = exParentTest.CreateNode("Login");
            loginPage.Login(url, username, password);

            exChildTest = exParentTest.CreateNode("Assert The Home Page product Label");
            homePage.productlabel(message1);

            exChildTest = exParentTest.CreateNode("Logout");
            sidebaritems.LogouttClick();

            exChildTest = exParentTest.CreateNode("Relogin");
            logoutPage.GetLoginTitle(message2);
        }
    }
}
