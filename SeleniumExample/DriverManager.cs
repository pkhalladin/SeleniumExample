using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumExample
{
    public static class DriverManager
    {
        public static IWebDriver Create()
        {
            IWebDriver driver;

#if CHROME
            ChromeOptions options = new ChromeOptions();
#if HEADLESS
            options.AddArgument("headless");
#endif // HEADLESS
            driver = new ChromeDriver(options);
#endif // CHROME

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5.0);

            return driver;
        }
    }
}
