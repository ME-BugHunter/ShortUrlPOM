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

        public BasePage(WebDriver driver)
        {
            this.driver = driver;
        }

        public virtual string BaseUrl { get; }
        public IWebElement LinkHome => driver.FindElement(By.LinkText("Home"));
        public IWebElement LinkAddUrl => driver.FindElement(By.LinkText("Add URL"));
        public IWebElement LinkShortUrls => driver.FindElement(By.LinkText("Short URLs"));
        public IWebElement ShortUrlsCount => driver.FindElement(By.XPath("//ul/li[1]/b"));
        public IWebElement UrlVisitorsCount => driver.FindElement(By.XPath("//ul/li[2]/b"));
        public IWebElement LabelPageHeading => driver.FindElement(By.TagName("h1"));
        public IWebElement LabelShortUrls => driver.FindElement(By.CssSelector("body > main > ul > li:nth-child(1)"));
        public IWebElement LabelUrlVisitors => driver.FindElement(By.CssSelector("body > main > ul > li:nth-child(2)"));


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

        public string getPageHeading()
        {
            return LabelPageHeading.Text;
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
