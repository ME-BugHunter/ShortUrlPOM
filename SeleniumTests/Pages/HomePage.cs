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

    }
}
