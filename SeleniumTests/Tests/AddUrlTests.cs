using SeleniumTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests.Tests
{
    public class AddUrlTests: BaseTest
    {
        private AddUrlPage page;

        [SetUp]
        public void SetUp()
        {
            this.page = new AddUrlPage(driver);
            page.Open();
        }

        [Test]
        public void Test_AddValidUrl()
        {
            string urlToAdd = "http://" + DateTime.Now.Ticks + ".com";
            page.inputUrl(urlToAdd);
            page.clickCreateButton();

            Assert.That(driver.PageSource.Contains(urlToAdd));

            Assert.That(page.getLastRowFirstCellText(), Is.EqualTo(urlToAdd));
        }

        [Test]
        public void Test_AddInvalidUrl()
        {
            string urlToAdd = "www." + DateTime.Now.Ticks + ".com";
            page.inputUrl(urlToAdd);
            page.clickCreateButton();

            Assert.That(page.getInvalidUrlErrorText(), Is.EqualTo("Invalid URL!"));
        }
    }
}
