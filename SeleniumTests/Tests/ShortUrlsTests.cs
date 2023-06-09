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
    }
}
