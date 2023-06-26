using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumMobileTests.Screens
{
    public class BaseScreen
    {
        protected readonly AndroidDriver<AndroidElement> driver;
        public BaseScreen(AndroidDriver<AndroidElement> driver)
        {
            this.driver = driver;
        }

        public void clickEnter()
        {
            driver.PressKeyCode(AndroidKeyCode.Keycode_ENTER);
        }
    }
}
