using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(WebDriver driver) : base(driver) { }
        public override string BaseUrl => "https://shorturl--mariaemanuilova.repl.co/";
        public IWebElement ShortUrlsCount => driver.FindElement(By.XPath("//ul/li[1]/b"));
        public IWebElement UrlVisitorsCount => driver.FindElement(By.XPath("//ul/li[2]/b")); 
        public IWebElement LabelShortUrls => driver.FindElement(By.CssSelector("body > main > ul > li:nth-child(1)"));
        public IWebElement LabelUrlVisitors => driver.FindElement(By.CssSelector("body > main > ul > li:nth-child(2)"));

        
    }
}
