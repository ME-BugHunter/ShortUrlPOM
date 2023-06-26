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
            var urlToAdd = "https://url" + DateTime.Now.Ticks + ".com";
            screen.setInputUrl(urlToAdd);
            screen.clickButtonCreate();

            var createdUrl = driver.FindElementByName(urlToAdd);
            Assert.IsNotEmpty(createdUrl.Text);
            Assert.That(createdUrl.Text, Is.EqualTo(urlToAdd));
        }
    }
}