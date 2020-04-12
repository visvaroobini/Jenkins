using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System;
using System.Threading;

namespace Tests
{
    public class Tests
    {

        IWebDriver driver = null;

        [SetUp]
        public void Setup()
        {

            var dir = AppDomain.CurrentDomain.BaseDirectory;
            //InternetExplorerOptions options = new InternetExplorerOptions();
            //options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
            //driver = new InternetExplorerDriver(dir,options);
            driver = new ChromeDriver(dir);

            driver.Navigate().GoToUrl("https://www.gograph.com");
        }

        [Test]
        public void Test1()
        {
            Thread.Sleep(3000);
            var url = this.driver.Url;
            var title = driver.Title;
            Assert.AreEqual("https://www.gograph.com/", url);
            Assert.AreEqual("Great ClipArt, Illustrations, and Vectors at Low Prices - GoGraph", title, "Title doesnt match");
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Quit();
        }
    }
}