using SeleniumTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests.Tests
{
    public class ShortUrlsTests: BaseTest
    {
        private ShortUrlsPage page;
        [SetUp]
        public void SetUp()
        {
            this.page = new ShortUrlsPage(driver);
            page.Open();
        }

        [Test]
        public void Test_CheckTopLeftCellText()
        {
            Assert.That(page.getTopLeftCellLabel(), Is.EqualTo("Original URL"));
        }

        [Test]
        public void Test_TryVisitInvalidUrl()
        {
            string invalidUrl = "http://shorturl--mariaemanuilova.repl.co/invalid53652";
            page.visitUrl(invalidUrl);

            Assert.That(page.getMessageCannotGetUrl(), Is.EqualTo("Cannot GET /invalid53652"));
        }

        [Test]
        public void Test_CheckShortUrlCounterIncrease()
        {
            int oldCounter = int.Parse(page.getTableFirstRowLastCellText());
            page.clickTableFirstRowSecondCellLink();
            page.switchToFirstTab();
            page.refreshPage();

            int newCounter = int.Parse(page.getTableFirstRowLastCellText());

            Assert.That(newCounter, Is.EqualTo(oldCounter + 1));
        }
    }
}
