using System.Drawing;
using System.Collections.ObjectModel;
using OpenQA.Selenium;

namespace OpenSelenium
{
    public partial interface IGraphicalElement : IWebElement
    {
        new Point Location { get; }

        new Size Size { get; }

        new bool Displayed { get; }

        new void Click();

        //void FindMe(string templatePath, double shapeLimit, double histogramLimit);
    }

    //not supported IWebElement actions
    public partial interface IGraphicalElement : IWebElement
    {
        [Obsolete("This is not supported for graphical elements.", true)]
        new ReadOnlyCollection<IWebElement> FindElements(By by);

        [Obsolete("This is not supported for graphical elements.", true)]
        new IWebElement FindElement(By by);

        [Obsolete("This is not supported for graphical elements.", true)]
        new void SendKeys(string text);

        [Obsolete("This is not supported for graphical elements.", true)]
        new string TagName { get; }

        [Obsolete("This is not supported for graphical elements.", true)]
        new string Text { get; }

        [Obsolete("This is not supported for graphical elements.", true)]
        new bool Enabled { get; }

        [Obsolete("This is not supported for graphical elements.", true)]
        new bool Selected { get; }

        [Obsolete("This is not supported for graphical elements.", true)]
        new void Clear();

        [Obsolete("This is not supported for graphical elements.", true)]
        new void Submit();

        [Obsolete("This is not supported for graphical elements.", true)]
        new string GetAttribute(string attributeName);

        [Obsolete("This is not supported for graphical elements.", true)]
        new string GetProperty(string propertyName);

        [Obsolete("This is not supported for graphical elements.", true)]
        new string GetCssValue(string propertyName);
    }
}