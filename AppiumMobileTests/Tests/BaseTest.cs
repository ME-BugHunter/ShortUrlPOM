using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumMobileTests.Tests
{
    public class BaseTest
    {
        protected AndroidDriver<AndroidElement> driver;
        private AppiumOptions options;
        private const string appLocation = @"E:\SoftUni\QA-Automation-Front-End\com.android.example.github.apk";
        private const string appiumServer = "http://127.0.0.1:4723/wd/hub";

        [SetUp]
        public void PrepareApp()
        {
            this.options = new AppiumOptions() { PlatformName = "Android" };
            options.AddAdditionalCapability("app", appLocation);
            driver = new AndroidDriver<AndroidElement>(new Uri(appiumServer), options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [TearDown]
        public void CloseApp()
        {
            driver.Quit();
        }

    }
}
