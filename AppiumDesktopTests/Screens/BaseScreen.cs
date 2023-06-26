using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumDesktopTests.Screens
{
    public class BaseScreen
    {
        protected readonly WindowsDriver<WindowsElement> driver;
        public WindowsElement inputBaseUrl => driver.FindElementByAccessibilityId("textBoxApiUrl");
        public WindowsElement connectButton => driver.FindElementByAccessibilityId("buttonConnect");
        public BaseScreen(WindowsDriver<WindowsElement> driver)
        {
            this.driver = driver;
        }
       
        public void setBaseUrl(string baseUrl)
        {
            inputBaseUrl.Click();
            inputBaseUrl.SendKeys(baseUrl);
        }

        public void clickConnectButton()
        {
            connectButton.Click();
        }

        public void clearInputUrlField()
        {
            inputBaseUrl.Clear();
        }
    }
}
