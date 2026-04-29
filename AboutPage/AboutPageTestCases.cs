using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.Core;
using static System.Net.Mime.MediaTypeNames;

namespace Project.AboutPage
{
    [TestClass]
    public class AboutPageTestCases : ExtentReport
    {
        BasePage basePage = new BasePage();
        LoginPage.LoginPage loginPage = new LoginPage.LoginPage();
        HomePage.HomePage homePage = new HomePage.HomePage();
        SideBarItems.SideBarItems sidebaritems = new SideBarItems.SideBarItems();
        AboutPage aboutPage = new AboutPage();

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
                    "Data.xml", "AboutPageMainTitle", DataAccessMethod.Sequential)]
        public void AboutPageMainTitle()
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

            exChildTest = exParentTest.CreateNode("Click On Sidebar About Link");
            sidebaritems.AboutClick();

            exChildTest = exParentTest.CreateNode("Assert About Page Main Title");
            aboutPage.AboutMainTitle(message2);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
                "Data.xml", "AboutPageHeaderMainTitle", DataAccessMethod.Sequential)]
        public void AboutPageHeaderMainTitle()
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

            exChildTest = exParentTest.CreateNode("Click On Sidebar About Link");
            sidebaritems.AboutClick();

            exChildTest = exParentTest.CreateNode("Assert About Page Header Title");
            aboutPage.GetHeaderAboutTitle(message2);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
               "Data.xml", "AboutPageHeaderLinkTitle", DataAccessMethod.Sequential)]
        public void AboutPageHeaderLinkTitle()
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

            exChildTest = exParentTest.CreateNode("Click On Sidebar About Link");
            sidebaritems.AboutClick();

            exChildTest = exParentTest.CreateNode("Assert The Link Of About Page Header");
            aboutPage.GetHeaderAboutLinkTitle(message2);
        }


        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
               "Data.xml", "ClickOnAboutPageHeaderCross", DataAccessMethod.Sequential)]
        public void ClickOnAboutPageHeaderCross()
        {
            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string message1 = TestContext.DataRow["message1"].ToString();
            string cross = TestContext.DataRow["cross"].ToString();
            string message2 = TestContext.DataRow["message2"].ToString();
            string message3 = TestContext.DataRow["message3"].ToString();

            exChildTest = exParentTest.CreateNode("Login");
            loginPage.Login(url, username, password);

            exChildTest = exParentTest.CreateNode("Assert The Home Page product Label");
            homePage.productlabel(message1);

            exChildTest = exParentTest.CreateNode("Click On Sidebar About Link");
            sidebaritems.AboutClick();

            exChildTest = exParentTest.CreateNode("Assert The Link Of About Page Header");
            aboutPage.AboutMainTitle(message2);

            exChildTest = exParentTest.CreateNode("Click On Cross Of About Page");
            aboutPage.CrossIconClick(message3);
        }



        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
          "Data.xml", "AboutPageSignUpButtonText", DataAccessMethod.Sequential)]
        public void AboutPageSignUpButtonText()
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

            exChildTest = exParentTest.CreateNode("Click On Sidebar About Link");
            sidebaritems.AboutClick();

            exChildTest = exParentTest.CreateNode(" Assert The Sign up of free Text Of About Page");
            aboutPage.SIGNUPTXT(message2);
        }



        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
  "Data.xml", "AboutPageDemoButtonText", DataAccessMethod.Sequential)]
        public void AboutPageDemoButtonText()
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

            exChildTest = exParentTest.CreateNode("Click On Sidebar About Link");
            sidebaritems.AboutClick();

            exChildTest = exParentTest.CreateNode("Assert Book a demo Text Of About Page");
            aboutPage.DEMOBTNTXT(message2);
        }



        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
"Data.xml", "CheckAboutPageLearnMoreAboutIntegrationsText", DataAccessMethod.Sequential)]
        public void CheckAboutPageLearnMoreAboutIntegrationsText()
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

            exChildTest = exParentTest.CreateNode("Assert About Page Main Title");
            aboutPage.AboutMainTitle(message2);

            exChildTest = exParentTest.CreateNode("Assert Learn more about integrations Of About Page");
            aboutPage.MainButtonText(message3);




        }

    }
}
