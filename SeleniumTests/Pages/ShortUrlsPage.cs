using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests.Pages
{
    public class ShortUrlsPage: BasePage
    {
        public ShortUrlsPage(WebDriver driver): base(driver) { }
        public override string BaseUrl => "https://shorturl--mariaemanuilova.repl.co/urls";
        public IWebElement TableShortUrls => driver.FindElement(By.ClassName("urls"));
        public IWebElement topLeftCellLabel => driver.FindElement(By.CssSelector("th:nth-child(1)"));

        public string getTopLeftCellLabel()
        {
            return topLeftCellLabel.Text;
        }

        public object getShortUrlsTable()
        {
            return TableShortUrls;
        }
    }
}
