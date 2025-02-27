using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using NUnit.Framework.Interfaces;
using System;

namespace HomersekletWPFTest
{
    public class Tests
    {
        protected const string WinAppDriverUrl = "http://127.0.0.1:4723";
        private const string Program = @"D:\rud-2\kodtarak_2024\14d_2024-25\WpfHomersekletTest\WpfHomersekletTest\bin\Debug\net8.0-windows\WpfHomersekletTest.exe";
        private const string ProgramPath = @"D:\rud-2\kodtarak_2024\14d_2024-25\WpfHomersekletTest\WpfHomersekletTest\bin\Debug\net8.0-windows\";

        protected static WindowsDriver<WindowsElement> driver;


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
        [TestCase(85, 29.444)]
        public void FahrenheitToCelsiusTest(double fahrenheit,double elvart)
        {
            var homerseklet = driver.FindElementByAccessibilityId("textboxHomerseklet");
            homerseklet.Clear();
            driver.FindElementByAccessibilityId("celsiusKivalaszt").Click();
            homerseklet.SendKeys(fahrenheit.ToString());
            driver.FindElementByAccessibilityId("buttonKonvertalas").Click();
            var eredmeny = driver.FindElementByAccessibilityId("konvertaltHomerseklet");
            
            Assert.AreEqual(elvart,Convert.ToDouble(eredmeny.Text),0.001);
        }

        [Test]
        [TestCase(21,69.8)]
        [TestCase(12,53.6)]
        [TestCase(32,89.6)]
        public void CelsiusToFahrenheitTest(double celsius,double elvart)
        {
            var homerseklet = driver.FindElementByAccessibilityId("textboxHomerseklet");
            homerseklet.Clear();
            driver.FindElementByAccessibilityId("fahrenheitKivalaszt").Click();
            homerseklet.SendKeys(celsius.ToString());
            driver.FindElementByAccessibilityId("buttonKonvertalas").Click();
            var eredmeny = driver.FindElementByAccessibilityId("konvertaltHomerseklet");

            Assert.AreEqual(elvart, Convert.ToDouble(eredmeny.Text), 0.001);

        }

        [OneTimeTearDown]
        public void Endtest()
        {
            driver.Close();
            driver.Quit();
        }
    }
}