using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
namespace SeleniumAutomation
{
    internal class RightClick
    {
        static IWebDriver driver;

        public static void Main(string[] args)
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.way2automation.com/";
            driver.Manage().Window.Maximize();

           IWebElement link= driver.FindElement(By.LinkText("Register Now"));

            Actions action = new Actions(driver);
            Thread.Sleep(1000);
            action.ContextClick(link);

        }
    }


}
