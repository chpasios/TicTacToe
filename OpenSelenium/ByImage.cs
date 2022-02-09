using OpenCvSharp;
using OpenQA.Selenium;

namespace OpenSelenium
{
    public partial class ByImage : By
    {
        private static readonly string StringPathMechanism = "string path text";
        private static readonly string PathMechanism = "path";

        private string imagePath;
        private double shapeLimit;
        private double histogramLimit;


        public string Screenshot { get; set; }

        public ByImage(string templatePath, double shapeLimit, double histogramLimit) : base()
        {
            this.imagePath = templatePath;
            this.shapeLimit = shapeLimit;
            this.histogramLimit = histogramLimit;
        }

        public override IWebElement FindElement(ISearchContext context)
        {
            IGraphicalElement graphicalElement = new GraphicalElement();

            //graphicalElement.FindMe(imagePath, shapeLimit, histogramLimit);



            //graphicalElement.FindMe();

            return graphicalElement;
        }

        public static ByImage StringPath(string templateToFind, double shapeLimit, double histogramLimit)
        {
            if (string.IsNullOrEmpty(templateToFind))
            {
                throw new ArgumentNullException($"{ templateToFind }", "Cannot find graphical element when a path is null or empty");
            }

            //Oxi edw ta parakatw
            //TODO: Here check if selector can be found.
            string selector = templateToFind;


            //var s = Path.GetFullPath(templateToFind);

            ByImage byImage = new ByImage(selector, shapeLimit, histogramLimit);
            byImage.Description = "By.ImageStrPath" + templateToFind;

            return byImage;
        }

        //use the below to check the selectors
        /*var selector = "ImageTemplates\\Netent\\Starburst\\Web\\Gr\\continueStarburst.jpg";
        var dllLocation = Assembly.GetExecutingAssembly().Location;
        var fileInfo = new FileInfo(dllLocation);
        string fullPath = Path.Join(fileInfo.DirectoryName, selector);

        string fullPathCombined = Path.Combine(fullPath);

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                // Do something
            }
            
            
            var charsInvalidFile = Path.GetInvalidFileNameChars();
        var charsInvalidePaths = Path.GetInvalidPathChars();

        //throw new InvalidSelectorException();

        string folderSelector = Path.GetDirectoryName(selector);
        string filleName = Path.GetFileName(selector);

        bool directoryExist = Directory.Exists(Path.GetDirectoryName(fullPath));
        bool fileExists = File.Exists(fullPath);


            return fullPathCombined;*/
    }

    //not supported IWebElement actions
    public partial class ByImage : By
    {
        [Obsolete("This is not supported from ByImage class.", true)]
        public static new ByImage Name(string nameToFind) => throw new NotImplementedException();

        [Obsolete("This is not supported from ByImage class.", true)]
        public static new ByImage Id(string idToFind) => throw new NotImplementedException();

        [Obsolete("This is not supported from ByImage class.", true)]
        public static new ByImage LinkText(string linkTextToFind) => throw new NotImplementedException();

        [Obsolete("This is not supported from ByImage class.", true)]
        public static new ByImage XPath(string xpathToFind) => throw new NotImplementedException();

        [Obsolete("This is not supported from ByImage class.", true)]
        public static new ByImage ClassName(string classNameToFind) => throw new NotImplementedException();

        [Obsolete("This is not supported from ByImage class.", true)]
        public static new ByImage PartialLinkText(string partialLinkTextToFind) => throw new NotImplementedException();

        [Obsolete("This is not supported from ByImage class.", true)]
        public static new ByImage TagName(string tagNameToFind) => throw new NotImplementedException();

        [Obsolete("This is not supported from ByImage class.", true)]
        public static new ByImage CssSelector(string cssSelectorToFind) => throw new NotImplementedException();
    }
}