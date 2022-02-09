using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace TicTacToe.Common
{
    public class WebDriverFactory
    {
        private IWebDriver driver = null;

        public IWebDriver GetWebDriver()
        {
            if (driver == null)
            {
                new DriverManager().SetUpDriver(new ChromeConfig());

                driver = new ChromeDriver();
            }

            return driver;
        }
    }
}
