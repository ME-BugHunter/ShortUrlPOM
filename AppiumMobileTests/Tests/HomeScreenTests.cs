using AppiumMobileTests.Screens;

namespace AppiumMobileTests.Tests
{
    public class HomeScreenTests: BaseTest
    {
        private HomeScreen screen;

        [SetUp]
        public void SetUp()
        {
            this.screen = new HomeScreen(driver);
        }

        [Test]
        public void Test_GithubMobileSearch()
        {
            screen.enterSearchText("Selenium");
            screen.clickEnter();

            //Assert Selenium search result text
            Assert.That(screen.getSeleniumResultText(), Is.EqualTo("SeleniumHQ/selenium"));

            screen.clickTextSelenium();

            //Assert Barancev is in the list
            Assert.That(screen.getBarancevText(), Is.EqualTo("barancev"));

            screen.clickListTextBarancev();

            Assert.That(screen.getTextFieldBarancevText(), Is.EqualTo("Alexei Barantsev"));
        }
    }
}