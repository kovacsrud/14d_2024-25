using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using NUnit.Framework.Interfaces;
using System;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace HomersekletWPFTest
{
    public class Tests
    {
        protected const string WinAppDriverUrl = "http://127.0.0.1:4723";
        private const string Program = @"D:\rud-2\kodtarak_2024\14d_2024-25\WpfHomersekletTest\WpfHomersekletTest\bin\Debug\net8.0-windows\WpfHomersekletTest.exe";
        private const string ProgramPath = @"D:\rud-2\kodtarak_2024\14d_2024-25\WpfHomersekletTest\WpfHomersekletTest\bin\Debug\net8.0-windows\";

        protected static WindowsDriver<WindowsElement> driver;

        protected static ExtentReports extReport;
        protected static ExtentTest extTest;

        [OneTimeSetUp]
        public static void ReportSetup()
        {
            extReport = new ExtentReports();
            extReport.AddSystemInfo("Hõmérséklet átváltás teszt","Automatizált teszt");
            extReport.AddSystemInfo("Tesztelõ","Teszt Ágnes");
            ExtentSparkReporter reporter = new ExtentSparkReporter(ProgramPath+"\\result.html");
            extReport.AttachReporter(reporter);
            reporter.Config.DocumentTitle = "Hõmérséklet konvertálás teszt riport";
            reporter.Config.ReportName = "Hõmérséklet konvertálás";
            reporter.Config.Theme = AventStack.ExtentReports.Reporter.Config.Theme.Standard;
        }


        [OneTimeSetUp]
        public static void Setup()
        {
            if (driver == null)
            {
                var appiumOptions = new AppiumOptions();
                appiumOptions.AddAdditionalCapability("app", Program);
                appiumOptions.AddAdditionalCapability("devicename", "Windows PC");
                driver = new WindowsDriver<WindowsElement>(new Uri(WinAppDriverUrl), appiumOptions);
            }

        }


        [Test]
        [TestCase(33,0.55555555)]
        [TestCase(21,-6.1111)]
        [TestCase(45, 7.2222)]
        [TestCase(85, 26.444)]
        public void FahrenheitToCelsiusTest(double fahrenheit,double elvart)
        {
            extTest = extReport.CreateTest("Fahrenheit átváltása celsiusra");
            var homerseklet = driver.FindElementByAccessibilityId("textboxHomerseklet");
            homerseklet.Clear();
            driver.FindElementByAccessibilityId("celsiusKivalaszt").Click();
            homerseklet.SendKeys(fahrenheit.ToString());
            driver.FindElementByAccessibilityId("buttonKonvertalas").Click();
            var eredmeny = driver.FindElementByAccessibilityId("konvertaltHomerseklet");
            
            Assert.AreEqual(elvart,Convert.ToDouble(eredmeny.Text),0.001);
            extTest.Log(Status.Pass,"Fahrenheit átváltása Celsiusra OK");
        }

        [Test]
        [TestCase(21,69.8)]
        [TestCase(12,53.6)]
        [TestCase(32,89.6)]
        public void CelsiusToFahrenheitTest(double celsius,double elvart)
        {
            extTest = extReport.CreateTest("Celsius átváltása Fahrenheitre");
            var homerseklet = driver.FindElementByAccessibilityId("textboxHomerseklet");
            homerseklet.Clear();
            driver.FindElementByAccessibilityId("fahrenheitKivalaszt").Click();
            homerseklet.SendKeys(celsius.ToString());
            driver.FindElementByAccessibilityId("buttonKonvertalas").Click();
            var eredmeny = driver.FindElementByAccessibilityId("konvertaltHomerseklet");

            Assert.AreEqual(elvart, Convert.ToDouble(eredmeny.Text), 0.001);
            extTest.Log(Status.Pass, "Celsius átváltása fahrenheitre OK");

        }

        [TearDown]
        public static void CloseReport()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stacktrace = TestContext.CurrentContext.Result.StackTrace;
            var errormsg = TestContext.CurrentContext.Result.Message;

            if (status==TestStatus.Failed)
            {
                ITakesScreenshot shot = (ITakesScreenshot)driver;
                var be=TestContext.CurrentContext.Test.Arguments[0];
                var elvart=TestContext.CurrentContext.Test.Arguments[1];
                var filename = $"result_{be}_{elvart}.png";
                Screenshot screenshot = shot.GetScreenshot();
                screenshot.SaveAsFile(ProgramPath+filename,ScreenshotImageFormat.Png);
                extTest.Log(Status.Fail,stacktrace+" "+errormsg);
                extTest.Log(Status.Fail, "Képernyõ");
                extTest.AddScreenCaptureFromPath(filename);


            }



            extReport.Flush();
        }

        [OneTimeTearDown]
        public void Endtest()
        {
            driver.Close();
            driver.Quit();
        }
    }
}