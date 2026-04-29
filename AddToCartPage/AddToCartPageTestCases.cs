using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.AboutPage;
using Project.Core;
using Project.HomePage;  // for HomePage
using Project.AddToCartPage; // for LoginPage
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.BrowsingContext;
using System;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Windows.Forms;
namespace Project.AddToCartPage
{
    [TestClass]
    public class AddToCartPageTestCases : ExtentReport
    {
        // Base page for driver initialization
        BasePage basePage = new BasePage();
        LoginPage.LoginPage loginPage = new LoginPage.LoginPage();
        HomePage.HomePage homePage = new HomePage.HomePage();
        AddToCartPage addtocartpage = new AddToCartPage();


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
        "AddToCartPage",
        DataAccessMethod.Sequential)]
        public void AddToCartPage()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string productName = TestContext.DataRow["message"].ToString();

            Thread.Sleep(5000);
            exChildTest = exParentTest.CreateNode("Login");
            // Login
            loginPage.Login(url, username, password);

            exChildTest = exParentTest.CreateNode("Assert Home Page Product Name");
            // Verify product exists in inventory
            homePage.VerifyHomeProduct(productName);

            exChildTest = exParentTest.CreateNode("Assert The Title Of Add To Cart Page");
            // Click product
            addtocartpage.ClickInventoryProduct(productName);
        }

    }
}
