using AppiumDesktopTests.Screens;

namespace AppiumDesktopTests.Tests
{
    public class HomeScreenTests: BaseTest
    {
        private HomeScreen screen;

        [SetUp]
        public void SetUp()
        {
            this.screen = new HomeScreen(driver);
            screen.clearInputUrlField();
            screen.setBaseUrl(appServer);
            screen.clickConnectButton();
        }

        [Test]
        public void Test_AssertUrlCanBeAdded()
        {
            Assert.Pass();
        }
    }
}