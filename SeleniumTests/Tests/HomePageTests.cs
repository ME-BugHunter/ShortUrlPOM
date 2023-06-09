using SeleniumTests.Pages;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests.Tests
{
    public class HomePageTests : BaseTest
    {
        private HomePage page; 

        [SetUp]
        public void SetUp()
        {
            this.page = new HomePage(driver);
            page.Open();
        }

        [Test]
        public void Test_IsHomePageOpen()
        {
            Assert.That(page.isPageOpen, Is.True);
        }

        [Test]
        public void Test_AssertPageTitle()
        {
            Assert.That(page.getPageTitle, Is.EqualTo("URL Shortener"));
        }

        [Test]
        public void Test_AssertPageHeading()
        {
            Assert.That(page.getPageHeading(), Is.EqualTo("URL Shortener"));
        }

        [Test]
        public void Test_NavigateToShortUrls()
        {
            page.openShortUrlsPage();
            Assert.That(page.GetUrl, Is.EqualTo("https://shorturl--mariaemanuilova.repl.co/urls"));
        }

        [Test]
        public void Test_NavigateToAddUrl()
        {
            page.openAddUrlPage();
            Assert.That(page.GetUrl, Is.EqualTo("https://shorturl--mariaemanuilova.repl.co/add-url"));
        }

    }
}
