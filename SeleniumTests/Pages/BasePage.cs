using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests.Pages
{
    public class BasePage
    {
        protected readonly WebDriver driver;
        public IWebElement LabelPageHeading => driver.FindElement(By.TagName("h1"));
        public IWebElement LinkHome => driver.FindElement(By.LinkText("Home"));
        public IWebElement LinkAddUrl => driver.FindElement(By.LinkText("Add URL"));
        public IWebElement LinkShortUrls => driver.FindElement(By.LinkText("Short URLs"));

        public BasePage(WebDriver driver)
        {
            this.driver = driver;
        }

        public virtual string BaseUrl { get; }

        public string getPageHeading()
        {
            return LabelPageHeading.Text;
        }

        public void Open()
        {
            driver.Navigate().GoToUrl(BaseUrl);
        }

        public string GetUrl()
        {
            return driver.Url;
        }

        public string getPageTitle()
        {
            return driver.Title;
        }

        public bool isPageOpen()
        {
            return driver.Url == BaseUrl;
        }

        
        public void switchToFirstTab()
        {
            driver.SwitchTo().Window(driver.WindowHandles[0]);
        }

        public void refreshPage()
        {
            driver.Navigate().Refresh();
        }

        public void visitUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void openHomePage()
        {
            LinkHome.Click();
        }

        public void openShortUrlsPage()
        {
            LinkShortUrls.Click();
        }

        public void openAddUrlPage()
        {
            LinkAddUrl.Click();
        }
    }
}
