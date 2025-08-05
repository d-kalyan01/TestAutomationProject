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

namespace SeleniumAutomation
{
    internal class FramesTest
    {

        static IWebDriver driver;

        public static void Main(string[] args)
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.w3schools.com/html/tryit.asp?filename=tryhtml_iframe_target";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            driver.SwitchTo().Frame("iframeResult"); // Switch to the iframe by name or ID

            
            driver.FindElement(By.TagName("a")).Click(); // Click the link inside the iframe
            Thread.Sleep(2000); // Wait for 2 seconds to observe the action
            driver.Quit(); // Close the browser

        }
    }
}
