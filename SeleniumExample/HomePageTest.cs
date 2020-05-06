using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumExample
{
    [TestClass]
    public class HomePageTest
    {
        private IWebDriver driver;

        [TestInitialize]
        public void Intialize()
        {
            driver = DriverManager.Create();
        }

        [TestCleanup]
        public void Cleanup()
        {
            driver.Close();
        }

        [TestMethod]
        public void IndexTest()
        {
            HomePage page;

            driver.Url = "https://google.pl";
            page = new HomePage(driver);

            Assert.AreEqual("Google", page.Title);
        }

        [TestMethod]
        public void SearchTest()
        {
            HomePage page;

            driver.Url = "https://google.pl";
            page = new HomePage(driver);
            page.SearchTextBox.SendKeys("aaa" + Keys.Enter);

            Assert.IsTrue(page.HasElement(By.Id("result-statx")));
        }
    }
}
