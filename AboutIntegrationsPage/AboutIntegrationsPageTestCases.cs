using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.AboutPage;
using Project.Core;
using Project.HomePage;
using Project.LoginPage;
using Project.AboutIntegrationsPage;
using System;
using System.Threading;

namespace Project.AboutIntegrationsPage
{
    [TestClass]
    public class AboutIntegrationsPageTestCases : ExtentReport
    {
        BasePage basePage = new BasePage();
        LoginPage.LoginPage loginPage = new LoginPage.LoginPage();
        HomePage.HomePage homePage = new HomePage.HomePage();
        AboutPage.AboutPage aboutPage = new AboutPage.AboutPage();
        SideBarItems.SideBarItems sidebaritems = new SideBarItems.SideBarItems();
        AboutIntegrationsPage aboutpageintegrationsPage = new AboutIntegrationsPage();

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
"Data.xml", "ClickOnAboutPageLearnMoreAboutIntegrationsButton", DataAccessMethod.Sequential)]
        public void ClickOnAboutPageLearnMoreAboutIntegrationsButton()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message1 = TestContext.DataRow["message1"].ToString();
            string message2 = TestContext.DataRow["message2"].ToString();
            string message3 = TestContext.DataRow["message3"].ToString();
            string message4 = TestContext.DataRow["message4"].ToString();

            exChildTest = exParentTest.CreateNode("Login");
            loginPage.Login(url, username, password);

            exChildTest = exParentTest.CreateNode("Assert The Home Page Product Label");
            homePage.productlabel(message1);

            exChildTest = exParentTest.CreateNode("Click o Sidebar About Link");
            sidebaritems.AboutClick();

            exChildTest = exParentTest.CreateNode("Click On About Page Main Button");
            aboutPage.AboutMainTitle(message2);
            aboutPage.MainButtonTextClick(message3);

            exChildTest = exParentTest.CreateNode("Click On Learn more about integrations to find the Sauce Labs integrates with the best tools for CI/CD, automated testing, team collaboration, and more");
            aboutpageintegrationsPage.TextAfterClickOnMainButtonTXT(message4);
        }
    }
}
