using NUnit.Framework;
using OpenQA.Selenium;
using TicTacToe.Common;
using TicTacToe.Pages;

namespace TicTacToe.Tests
{
    public class SampleTests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            WebDriverFactory webDriverFactory = new WebDriverFactory();
            driver = webDriverFactory.GetWebDriver();
        }

        [Test]
        public void NavigateToGamePage()
        {
            GamePage gamePage = new GamePage(driver);
            gamePage.NavigateToGame();
        }

        [Test]
        public void CheckImageRecognition()
        {
            GamePage gamePage = new GamePage(driver);
            gamePage.NavigateToGame();
            gamePage.FirstClikOnImage();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}