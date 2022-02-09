using System;
using System.Drawing;
using System.Collections.ObjectModel;
using OpenQA.Selenium;

namespace OpenSelenium
{
    public class GraphicalElement : IGraphicalElement
    {
        public GraphicalElement() { }

        public Point Location
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Size Size => throw new NotImplementedException();

        public bool Displayed => throw new NotImplementedException();

        public void Click() => throw new NotImplementedException();

        public IGraphicalElement FindGraphicalElement(ByImage by)
        {
            throw new NotImplementedException();
        }

        /*public void FindMe(string templatePath, double shapeLimit, double histogramLimit)
        {
            throw new NotImplementedException();
        }*/

        //not supported IWebElement actions
        public IWebElement FindElement(By by) => throw new NotImplementedException();

        public ReadOnlyCollection<IWebElement> FindElements(By by) => throw new NotImplementedException();

        public string TagName => throw new NotImplementedException();

        public string Text => throw new NotImplementedException();

        public bool Enabled => throw new NotImplementedException();

        public bool Selected => throw new NotImplementedException();

        public void Clear() => throw new NotImplementedException();

        public string GetAttribute(string attributeName) => throw new NotImplementedException();

        public string GetCssValue(string propertyName) => throw new NotImplementedException();

        public string GetProperty(string propertyName) => throw new NotImplementedException();

        public void SendKeys(string text) => throw new NotImplementedException();

        public void Submit() => throw new NotImplementedException();

        public string GetDomAttribute(string attributeName) => throw new NotImplementedException();

        public string GetDomProperty(string propertyName) => throw new NotImplementedException();

        public ISearchContext GetShadowRoot() => throw new NotImplementedException();
    }
}