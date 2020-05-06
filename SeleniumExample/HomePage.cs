using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumExample
{
    public class HomePage : AbstractPage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement SearchTextBox => FindElement(By.Name("q"));
        public IWebElement SearchButton => FindElement(By.Name("btnK"));
        public string Title => driver.Title;

        
    }
}
