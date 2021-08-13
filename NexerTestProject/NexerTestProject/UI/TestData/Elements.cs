using OpenQA.Selenium;


namespace NexerTestProject.UI.TestData
{
    public class Elements
    {
        public string ExpectedSectionName = "DESIGN & COMMUNICATION";
        public static By MenuButton = By.CssSelector("#nav-hamburger-toggle");
        public static By DesigAndCommunicationTitle = By.XPath("//*[contains(text(),'Design & Communication')]");
    }
}
