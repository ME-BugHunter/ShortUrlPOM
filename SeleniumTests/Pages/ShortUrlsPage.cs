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
        public IWebElement TopLeftCellLabel => driver.FindElements(By.CssSelector("tr > th"))[0];
        public IWebElement MessageCannotGetUrl => driver.FindElement(By.CssSelector("body > pre"));
        public IWebElement TableFirstRow => driver.FindElements(By.CssSelector("tbody > tr")).First();
        public IWebElement TableFirstRowSecondCell => TableFirstRow.FindElements(By.CssSelector("td"))[1];
        public IWebElement TableFirstRowLastCell => TableFirstRow.FindElements(By.CssSelector("td")).Last(); 

        public string getTopLeftCellLabel()
        {
            return TopLeftCellLabel.Text;
        }

        public object getShortUrlsTable()
        {
            return TableShortUrls;
        }

        
        public string getMessageCannotGetUrl()
        {
            return MessageCannotGetUrl.Text;
        }

        public void clickTableFirstRowSecondCell()
        {
            TableFirstRowSecondCell.Click();
        }

        public string getTableFirstRowLastCellText()
        {
            return TableFirstRowLastCell.Text;
        }
    }
}
