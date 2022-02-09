using OpenQA.Selenium;
using OpenSelenium;

namespace TicTacToe.Pages
{
    public class GamePage
    {
        private IWebDriver _driver;

        public GamePage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IGraphicalElement graphicalElement => _driver.FindGraphicalElement(ByImage.StringPath("", 0, 0));

        public void NavigateToGame() => _driver.Navigate().GoToUrl("https://www.google.com/");

        public void FirstClikOnImage()
        {
            graphicalElement.Click();
        }
    }
}