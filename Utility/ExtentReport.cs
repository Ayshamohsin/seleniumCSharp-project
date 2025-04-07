using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Config;
using OpenQA.Selenium;
using System;
using System.IO;

namespace SpecFlowProject92.Utility
{
    public class ExtentReport
    {
        public static ExtentReports _extentReports;
        public static ExtentTest _feature;
        public static ExtentTest _scenario;

        public static string dir = AppDomain.CurrentDomain.BaseDirectory;
        public static string testResultPath = dir.Replace("bin\\Debug\\net6.0", "TestResults");

        public static void ExtentReportInit()
        {
            Console.WriteLine("Initializing Extent Report...");

            // Ensure TestResults directory exists
            if (!Directory.Exists(testResultPath))
            {
                Directory.CreateDirectory(testResultPath);
                Console.WriteLine($"TestResults directory created at {testResultPath}");
            }

            // Use Spark Reporter for better test reporting
            var sparkReporter = new ExtentSparkReporter(Path.Combine(testResultPath, "extent-report.html"));

            // Set Spark Report configurations
            sparkReporter.Config.ReportName = "Automation Test Report";
            sparkReporter.Config.DocumentTitle = "Test Automation Report";
            sparkReporter.Config.Theme = Theme.Standard;

            // Initialize ExtentReports with the reporter
            _extentReports = new ExtentReports();
            _extentReports.AttachReporter(sparkReporter);

            // Add system info
            _extentReports.AddSystemInfo("Application", "TESTING");
            _extentReports.AddSystemInfo("Browser", "Chrome");
            _extentReports.AddSystemInfo("OS", "Windows");

            Console.WriteLine("Extent Report initialized.");
        }

        public static void ExtentReportTearDown()
        {
            Console.WriteLine("Flushing Extent Report...");
            _extentReports.Flush();  // Ensure the report is flushed
            Console.WriteLine("Extent Report flushed.");
        }

        public static string AddScreenshot(IWebDriver driver, ScenarioContext scenarioContext)
        {
            ITakesScreenshot takesScreenshot = (ITakesScreenshot)driver;
            Screenshot screenshot = takesScreenshot.GetScreenshot();
            string screenshotLocation = Path.Combine(testResultPath, scenarioContext.ScenarioInfo.Title + ".png");
            screenshot.SaveAsFile(screenshotLocation);
            return screenshotLocation;
        }
    }
}
