using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

namespace SeleniumExample
{
    public static class DriverManager
    {
        public static IWebDriver Create()
        {
            IWebDriver driver;
            ChromeOptions options = new ChromeOptions();

            //options.AddArguments("headless");
            driver = new ChromeDriver(options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5.0);

            return driver;
        }
    }
}
