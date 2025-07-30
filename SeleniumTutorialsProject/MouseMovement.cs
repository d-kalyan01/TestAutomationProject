using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Windows;
using OpenQA.Selenium.Interactions;

namespace SeleniumAutomation
{
    internal class MouseMovement
    {
        static IWebDriver driver;

        public static void Main(string[] args)
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.way2automation.com/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement menu= driver.FindElement(By.Id("menu-item-27597"));


            Actions action = new Actions(driver);
            
            action.MoveToElement(menu);
            Thread.Sleep(1000);
            driver.Close();



        }
    }
}
