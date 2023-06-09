using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests.Pages
{
    public class AddUrlPage: BasePage
    {
        public AddUrlPage(WebDriver driver) : base(driver) { }
        public override string BaseUrl => "https://shorturl--mariaemanuilova.repl.co/add-url";
        public IWebElement InputUrl => driver.FindElement(By.Id("url"));
        public IWebElement ButtonCreate => driver.FindElement(By.XPath("//button[@type='submit']"));
        public IWebElement TableLastRow => driver.FindElements(By.CssSelector("table > tbody > tr")).Last();
        public IWebElement LastRowFirstCell => TableLastRow.FindElements(By.CssSelector("td")).First();
        public IWebElement InvalidUrlError => driver.FindElement(By.ClassName("err"));

        public void clickCreateButton()
        {
            ButtonCreate.Click();
        }

        public void inputUrl(string urlToAdd)
        {
            InputUrl.SendKeys(urlToAdd);
        }

        public string getLastRowFirstCellText()
        {
            return LastRowFirstCell.Text;
        }

        public string getInvalidUrlErrorText()
        {
            return InvalidUrlError.Text;
        }
    }
}
