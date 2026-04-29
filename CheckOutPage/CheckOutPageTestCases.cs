using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.BrowsingContext;
using Project.AboutPage;
using Project.AddToCartPage;
using Project.Core;
using Project.HomePage;
using Project.LoginPage;
using System;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Windows.Forms;
using static Azure.Core.HttpHeader;

namespace Project.CheckOutPage
{
    [TestClass]
    public class CheckOutPageTestCases : ExtentReport
    {



        BasePage basePage = new BasePage();
        LoginPage.LoginPage loginPage = new LoginPage.LoginPage();
        HomePage.HomePage homePage = new HomePage.HomePage();
        AddToCartPage.AddToCartPage addtocartpage = new AddToCartPage.AddToCartPage();
        CheckOutPage checkoutpage = new CheckOutPage();





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
        "CartIconPage",
        DataAccessMethod.Sequential)]
        public void CartIconPage()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message1 = TestContext.DataRow["message1"].ToString();
            string message2 = TestContext.DataRow["message2"].ToString();
            string message3 = TestContext.DataRow["message3"].ToString();
            string locator = TestContext.DataRow["locator"].ToString();
            string removelocator = TestContext.DataRow["removelocator"].ToString();

            Thread.Sleep(5000);
            exChildTest = exParentTest.CreateNode("Login");

            loginPage.Login(url, username, password);

            exChildTest = exParentTest.CreateNode("Assert The Title Of Cart Icon Page");
            checkoutpage.VisitCartIconPage(locator, message1, removelocator, message2, message3);


        }




        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
"|DataDirectory|\\Data.xml",
"ClickOnRemoveButtonInCartIconPage",
DataAccessMethod.Sequential)]
        public void ClickOnRemoveButtonInCartIconPage()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message1 = TestContext.DataRow["message1"].ToString();
            string message2 = TestContext.DataRow["message2"].ToString();
            string message3 = TestContext.DataRow["message3"].ToString();
            string locator = TestContext.DataRow["locator"].ToString();
            string removelocator = TestContext.DataRow["removelocator"].ToString();

            Thread.Sleep(5000);
            exChildTest = exParentTest.CreateNode("Login");
            loginPage.Login(url, username, password);

            exChildTest = exParentTest.CreateNode("Assert The Title Of Cart Icon Pag and Click On Remove Button To Remove That Button And Search Your Cart Title");
            checkoutpage.GetHOMEAddtoCartIconDescription(locator, message1, removelocator, message2, message3);

        }





        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
"|DataDirectory|\\Data.xml",
"ContinueShopping",
DataAccessMethod.Sequential)]
        public void ContinueShopping()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message1 = TestContext.DataRow["message1"].ToString();
            string message2 = TestContext.DataRow["message2"].ToString();
            string locator = TestContext.DataRow["locator"].ToString();


            Thread.Sleep(5000);
            exChildTest = exParentTest.CreateNode("Login");
            loginPage.Login(url, username, password);

            exChildTest = exParentTest.CreateNode("Click On Continue Button To Revisit the Home Page");
            checkoutpage.Continueshopping(locator, message1, message2);
        }



        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
"|DataDirectory|\\Data.xml",
"CancelTheCheckout",
DataAccessMethod.Sequential)]
        public void CancelTheCheckout()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message1 = TestContext.DataRow["message1"].ToString();
            string message2 = TestContext.DataRow["message2"].ToString();
            string message3 = TestContext.DataRow["message3"].ToString();
            string locator = TestContext.DataRow["locator"].ToString();

            Thread.Sleep(5000);
            exChildTest = exParentTest.CreateNode("Login");
            loginPage.Login(url, username, password);

            exChildTest = exParentTest.CreateNode("Click On Cancel To Cancel The Checkout");
            checkoutpage.Cancelproduct(locator, message1, message2, message3);

        }


        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
"|DataDirectory|\\Data.xml",
"FinishWithOrder",
DataAccessMethod.Sequential)]
        public void FinishWithOrder()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message1 = TestContext.DataRow["message1"].ToString();
            string message2 = TestContext.DataRow["message2"].ToString();
            string message3 = TestContext.DataRow["message3"].ToString();
            string message4 = TestContext.DataRow["message4"].ToString();
            string locator = TestContext.DataRow["locator"].ToString();
            string firstName = TestContext.DataRow["FirstName"].ToString();
            string lastName = TestContext.DataRow["LastName"].ToString();
            string code = TestContext.DataRow["PostalCode"].ToString();

            Thread.Sleep(5000);
            exChildTest = exParentTest.CreateNode("Login");
            loginPage.Login(url, username, password);

            exChildTest = exParentTest.CreateNode("Click On Finish Button With Order To Checkout the Product");
            checkoutpage.finishwithorder(locator, message1, message2, message3, firstName, lastName, code, message4);
        }



        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
"|DataDirectory|\\Data.xml",
"FinishWithNoOrder",
DataAccessMethod.Sequential)]
        public void FinishWithNoOrder()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message1 = TestContext.DataRow["message1"].ToString();
            string message2 = TestContext.DataRow["message2"].ToString();
            string message3 = TestContext.DataRow["message3"].ToString();
            string message4 = TestContext.DataRow["message4"].ToString();
            string locator = TestContext.DataRow["locator"].ToString();
            string removelocator = TestContext.DataRow["removelocator"].ToString();
            string firstName = TestContext.DataRow["FirstName"].ToString();
            string lastName = TestContext.DataRow["LastName"].ToString();
            string code = TestContext.DataRow["PostalCode"].ToString();

            Thread.Sleep(5000);
            exChildTest = exParentTest.CreateNode("Login");
            loginPage.Login(url, username, password);

            exChildTest = exParentTest.CreateNode("Click On Finish Button Without Order To Checkout the Product");
            checkoutpage.finishwithnoorder(locator, removelocator, message1, message2, message3, firstName, lastName, code, message4);
        }





        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
"|DataDirectory|\\Data.xml",
"CheckOutTheProductWithNoFirstName",
DataAccessMethod.Sequential)]
        public void CheckOutTheProductWithNoFirstName()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message1 = TestContext.DataRow["message1"].ToString();
            string message2 = TestContext.DataRow["message2"].ToString();
            string message3 = TestContext.DataRow["message3"].ToString();
            string message4 = TestContext.DataRow["message4"].ToString();
            string locator = TestContext.DataRow["locator"].ToString();
            string firstName = TestContext.DataRow["FirstName"].ToString();
            string lastName = TestContext.DataRow["LastName"].ToString();
            string code = TestContext.DataRow["PostalCode"].ToString();

            Thread.Sleep(5000);
            exChildTest = exParentTest.CreateNode("Login");
            loginPage.Login(url, username, password);

            exChildTest = exParentTest.CreateNode("Checkout The Product With No First Name");
            checkoutpage.Checkouttheproductwithnofirstname(locator, message1, message2, message3, firstName, lastName, code, message4);
        }





        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
"|DataDirectory|\\Data.xml",
"CheckOutTheProductWithNoLastName",
DataAccessMethod.Sequential)]
        public void CheckOutTheProductWithNoLastName()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message1 = TestContext.DataRow["message1"].ToString();
            string message2 = TestContext.DataRow["message2"].ToString();
            string message3 = TestContext.DataRow["message3"].ToString();
            string message4 = TestContext.DataRow["message4"].ToString();
            string locator = TestContext.DataRow["locator"].ToString();
            string firstName = TestContext.DataRow["FirstName"].ToString();
            string lastName = TestContext.DataRow["LastName"].ToString();
            string code = TestContext.DataRow["PostalCode"].ToString();

            Thread.Sleep(5000);

            exChildTest = exParentTest.CreateNode("Login");
            loginPage.Login(url, username, password);

            exChildTest = exParentTest.CreateNode(" Checkout The Product With No Last Name");
            checkoutpage.Checkouttheproductwithnolastname(locator, message1, message2, message3, firstName, lastName, code, message4);
        }




        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
"|DataDirectory|\\Data.xml",
"CheckOutTheProductWithNoPostalCode",
DataAccessMethod.Sequential)]
        public void CheckOutTheProductWithNoPostalCode()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message1 = TestContext.DataRow["message1"].ToString();
            string message2 = TestContext.DataRow["message2"].ToString();
            string message3 = TestContext.DataRow["message3"].ToString();
            string message4 = TestContext.DataRow["message4"].ToString();
            string locator = TestContext.DataRow["locator"].ToString();
            string firstName = TestContext.DataRow["FirstName"].ToString();
            string lastName = TestContext.DataRow["LastName"].ToString();
            string code = TestContext.DataRow["PostalCode"].ToString();

            Thread.Sleep(5000);
            exChildTest = exParentTest.CreateNode("Login");
            loginPage.Login(url, username, password);

            exChildTest = exParentTest.CreateNode("Checkout The Product With No Postal Code");
            checkoutpage.Checkouttheproductwithnopostalcode(locator, message1, message2, message3, firstName, lastName, code, message4);
        }




    }
}
