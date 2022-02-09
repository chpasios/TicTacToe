using OpenQA.Selenium;

namespace OpenSelenium
{
    public static class IWebDriverGraphicalExtensions
    {
        public static IGraphicalElement FindGraphicalElement(this IWebDriver driver, ByImage byImage)
        {
            byImage.Screenshot = driver.TakeScreenshotOpenCV();

            IGraphicalElement graphicalElement = (IGraphicalElement)driver.FindElement(byImage);


            return graphicalElement;
        }

        /// <summary>
        /// Provides a mechanism that can take screenshots and save them to Temp folder
        /// </summary>
        /// <param name="webDriver">Selenium web driver</param>
        /// <returns>The image's file name</returns>
        public static string TakeScreenshotOpenCV(this IWebDriver webDriver)
        {
            //TODO: convert png to jpg, see this answer -> https://stackoverflow.com/questions/60048149/converting-png-to-jpg-in-python
            var ss = ((ITakesScreenshot)webDriver).GetScreenshot();
            var filename = Path.Combine(Path.GetTempPath(), string.Format(@"{0}.jpg", "OpenCVScreenshots"));
            ss.SaveAsFile(filename);

            return filename;
        }
    }
}
//GraphicalRecognition