using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core
{
    public class ExtentReport
    {
        public static ExtentReports extentReports;
        public static ExtentTest exParentTest;
        public static ExtentTest exChildTest;
        public static string ReportDirectory;   // ← ADD THIS LINE

        public static void CreateReport(string dirpath)
        {
            extentReports = new ExtentReports();
            ReportDirectory = Path.GetDirectoryName(dirpath);   // ← ADD THIS LINE
            var sparkReport = new ExtentSparkReporter(@dirpath);
            extentReports.AttachReporter(sparkReport);
        }
    }
}
