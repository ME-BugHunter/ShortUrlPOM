using AppiumDesktopTests.Screens;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AppiumDesktopTests.Tests
{
    public class BaseTest
    {
        protected WindowsDriver<WindowsElement> driver;
        private AppiumOptions options;
        private const string appLocation = @"E:\SoftUni\Prep Exam Myself\ShortURL-DesktopClient-v1.0.net6\ShortURL-DesktopClient.exe";
        private const string appiumServer = "http://127.0.0.1:4723/wd/hub";
        protected const string appServer = "https://shorturl--mariaemanuilova.repl.co/api";


        [SetUp]
        public void PrepareApp()
        {
            this.options = new AppiumOptions();
            options.AddAdditionalCapability("app", appLocation);
            driver = new WindowsDriver<WindowsElement>(new Uri(appiumServer), options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [TearDown]
        public void CloseApp()
        {
            this.driver.Quit();
        }
    }
}
