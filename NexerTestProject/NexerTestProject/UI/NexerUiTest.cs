using NUnit.Framework;
using OpenQA.Selenium;
using NexerTestProject.UI.TestData;
using System.Threading;

namespace NexerTestProject.UI
{
    public class Tests : Elements
    {
        private IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://nexergroup.com/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void NexerMainPage_Menu_VerifyMenuOptions()
        {
            driver.FindElement(MenuButton).Click();
            Thread.Sleep(300);
            var actualName = driver.FindElement(DesigAndCommunicationTitle).Text;
            Assert.AreEqual(ExpectedSectionName, actualName);
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
