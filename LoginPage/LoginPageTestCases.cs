using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.Core;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xunit;
using Xunit.Sdk;

namespace Project.LoginPage
{
    [TestClass]
    public class LoginPageTestCases : ExtentReport
    {
        LoginPage loginPage = new LoginPage();
        BasePage basePage = new BasePage();


        #region Initializations and Cleanups


        public TestContext TestContext { get; set; }
        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext context)
        {
            String ResultFilePath = @"C:\Users\mr610\source\repos\Automation-Framework-For-SauceDemoWebsite-Mujeeb-Using-Selenium-C#\ExtentReports\TestExecLog_" + DateTime.Now.ToString("yyyyMMDDHHmmss") + ".html";
            CreateReport(ResultFilePath);
        }
        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            MessageBox.Show("Assembly CleanUp");
        }
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            MessageBox.Show("Class Initialize");
        }
        [ClassCleanup]
        public static void ClassCleanup()
        {
            MessageBox.Show("Class CleanUp");

        }
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
        #endregion

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "LoginWithValidCredientials", DataAccessMethod.Sequential)]
        public void LoginWithValidCredientials()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message = TestContext.DataRow["message"].ToString();

            exChildTest = exParentTest.CreateNode("Login Page Through Valid Credientials");
            loginPage.Login(url, username, password);


        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "LoginWithInvalidCredientials", DataAccessMethod.Sequential)]
        public void LoginWithInvalidCredientials()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string Errormessage = TestContext.DataRow["Errormessage"].ToString();

            exChildTest = exParentTest.CreateNode("Login Page Through Invalid Credientials");
            loginPage.Login(url, username, password);

        }


    }
}
