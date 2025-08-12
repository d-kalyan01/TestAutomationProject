using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;


namespace SeleniumAutomation
{
    internal class ScrollToElement
    {
        static IWebDriver driver;

        public static void Main(String[] args)
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.way2automation.com/";
            driver.Manage().Window.Minimize();

            IWebElement link = driver.FindElement(By.XPath("//h4[normalize-space()='ABOUT US']"));
            IJavaScriptExecutor je = driver as IJavaScriptExecutor;
            je.ExecuteScript("arguments[0].scrollIntoView(true);", link);
            Thread.Sleep(2000);
        }

    }
}

