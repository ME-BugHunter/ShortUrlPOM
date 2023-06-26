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
        public WindowsElement ButtonAdd => driver.FindElementByAccessibilityId("buttonAdd");
        public WindowsElement InputUrl => driver.FindElementByAccessibilityId("textBoxURL");
        public WindowsElement ButtonCreate => driver.FindElementByAccessibilityId("buttonCreate");

        public void clickButtonAdd()
        {
            ButtonAdd.Click();
        }

        public void clickButtonCreate()
        {
            ButtonCreate.Click();
        }

        public void setInputUrl(string url)
        {
            InputUrl.Click();
            InputUrl.SendKeys(url);
        }

    }
}
