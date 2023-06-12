using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumDesktopTests.Screens
{
    public class HomeScreen: BaseScreen
    {
        public HomeScreen(WindowsDriver<WindowsElement> driver) : base(driver) { }
    }
}
