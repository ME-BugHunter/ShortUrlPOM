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
    }
}
