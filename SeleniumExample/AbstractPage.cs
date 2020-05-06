using OpenQA.Selenium;
using System;

namespace SeleniumExample
{
    public class AbstractPage
    {
        protected IWebDriver driver;

        public AbstractPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement FindElement(By by)
        {
            return driver.FindElement(by);
        }

        public bool HasElement(By by)
        {
            return driver.FindElements(by).Count > 0;
        }
    }
}
