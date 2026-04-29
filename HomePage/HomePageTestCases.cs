using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.Core;
using System.Threading;

namespace Project.HomePage // ✅ separate namespace for tests
{
    [TestClass]
    public class HomePageTestCases : ExtentReport
    {
        // Base page for driver initialization
        BasePage basePage = new BasePage();
        LoginPage.LoginPage loginPage = new LoginPage.LoginPage();
        HomePage homePage = new HomePage();


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
                  "HomePageProductText",
                  DataAccessMethod.Sequential)]
        public void HomePageProductText()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string productName = TestContext.DataRow["message"].ToString();


            Thread.Sleep(5000);
            exChildTest = exParentTest.CreateNode("Login");
            // Login
            loginPage.Login(url, username, password);
            // Click social media link

            exChildTest = exParentTest.CreateNode("Assert Home Page Product Text");
            // Switch to new window and validate
            homePage.VerifyHomeProduct(productName);


        }


        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "SortHighToLow", DataAccessMethod.Sequential)]
        public void SortHighToLow()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string sortOption = TestContext.DataRow["sort"].ToString();


            exChildTest = exParentTest.CreateNode("Login");
            loginPage.Login(url, username, password);

            exChildTest = exParentTest.CreateNode("Sort High To Low");
            homePage.SortProduct(sortOption);
            Thread.Sleep(2000);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "SortLowToHigh", DataAccessMethod.Sequential)]
        public void SortLowToHigh()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string sortOption = TestContext.DataRow["sort"].ToString();


            exChildTest = exParentTest.CreateNode("Login");
            loginPage.Login(url, username, password);

            exChildTest = exParentTest.CreateNode("Sort Low To High");
            homePage.SortProduct(sortOption);
        }


        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "SortAToZ", DataAccessMethod.Sequential)]
        public void SortAToZ()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string sortOption = TestContext.DataRow["sort"].ToString();


            exChildTest = exParentTest.CreateNode("Login");
            loginPage.Login(url, username, password);

            exChildTest = exParentTest.CreateNode("Sort A to Z");
            homePage.SortProduct(sortOption);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "SortZToA", DataAccessMethod.Sequential)]
        public void SortZToA()

        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string sortOption = TestContext.DataRow["sort"].ToString();


            exChildTest = exParentTest.CreateNode("Login");
            loginPage.Login(url, username, password);

            exChildTest = exParentTest.CreateNode("Sort Z To A");
            homePage.SortProduct(sortOption);
        }













        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
              "|DataDirectory|\\Data.xml",
              "CheckHomePageProductRemoveButtonText",
              DataAccessMethod.Sequential)]
        public void CheckHomePageProductAddToCartButtonText()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string productName = TestContext.DataRow["message1"].ToString(); // Add to cart
            string locator = TestContext.DataRow["locator"].ToString();

            exChildTest = exParentTest.CreateNode("Login");
            // Login
            loginPage.Login(url, username, password);

            exChildTest = exParentTest.CreateNode("Assert Add To Cart Button Text");
            // Validate Add to Cart button text inside HomePage class
            homePage.HomeProductBTNText(productName, locator);
        }



        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
        "|DataDirectory|\\Data.xml",
        "CheckHomePageProductRemoveButtonText",
        DataAccessMethod.Sequential)]
        public void CheckHomePageProductRemoveButtonText()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message1 = TestContext.DataRow["message1"].ToString();
            string message2 = TestContext.DataRow["message2"].ToString();
            string locator = TestContext.DataRow["locator"].ToString();
            string removelocator = TestContext.DataRow["removelocator"].ToString();

            Thread.Sleep(5000);
            exChildTest = exParentTest.CreateNode("Login");
            loginPage.Login(url, username, password);

            exChildTest = exParentTest.CreateNode("Click On Remove Button To Remove That Button");
            homePage.CheckremoveBTNText(message1, message2, locator, removelocator);



        }


    }
}
