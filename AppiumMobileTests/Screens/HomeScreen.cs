using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppiumMobileTests.Screens
{
    public class HomeScreen: BaseScreen
    {
        public HomeScreen(AndroidDriver<AndroidElement> driver) : base(driver) { }
        public AndroidElement InputSearchField => driver.FindElementById("com.android.example.github:id/input");
        public AndroidElement TextSelenium => driver.FindElementByXPath("//android.view.ViewGroup/android.widget.TextView[2]");
        public AndroidElement ListTextBarancev => driver.FindElementByXPath("//android.widget.FrameLayout[2]/android.view.ViewGroup/android.widget.TextView");
        public AndroidElement TextFieldBarancev => driver.FindElementByXPath("//android.widget.TextView[@content-desc='user name']");

        public void enterSearchText(string inputText)
        {
            InputSearchField.Click();
            InputSearchField.SendKeys(inputText);
        }

        public void clickTextSelenium()
        {
            TextSelenium.Click();
        }

        public void clickListTextBarancev()
        {
            ListTextBarancev.Click();
        }

        public string getSeleniumResultText()
        {
            return TextSelenium.Text;
        }

        public string getBarancevText()
        {
            return ListTextBarancev.Text;
        }

        public string getTextFieldBarancevText()
        {
            return TextFieldBarancev.Text;
        }
    }
}
