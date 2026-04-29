using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

namespace Project.Core
{
    public class BasePage
    {
        public static IWebDriver driver;
        public void SeleniumInit()
        {
            ChromeOptions options = new ChromeOptions();
            // Disable Chrome's password leak detection (prevents the "Change your password" popup)
            options.AddUserProfilePreference("profile.password_manager_leak_detection", false);
            options.AddUserProfilePreference("profile.password_manager_enabled", false);
            // Optional: also disable Safe Browsing features that might trigger popups
            options.AddArgument("--disable-features=PasswordLeakDetection");

            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
        }
        public void DriverClose()
        {
            driver.Close();
        }



        public static void TakeScreenShot(Status status, string StepDetail)
        {
            string folderPath = @"C:\Users\mr610\source\repos\Automation-Framework-For-SauceDemoWebsite-Mujeeb-Using-Selenium-C#\ExtentReports\images";

            // Ensure folder exists
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            string fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + ".png";

            string fullPath = Path.Combine(folderPath, fileName);

            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            File.WriteAllBytes(fullPath, screenshot.AsByteArray);

            // Convert full path to relative path
            Uri reportUri = new Uri(ExtentReport.ReportDirectory + "\\");
            Uri imageUri = new Uri(fullPath);

            string relativePath = reportUri.MakeRelativeUri(imageUri)
                                           .ToString()
                                           .Replace('/', '\\');

            ExtentReport.exChildTest.Log(status, StepDetail,
                MediaEntityBuilder.CreateScreenCaptureFromPath(relativePath).Build());
        }



    }
}
