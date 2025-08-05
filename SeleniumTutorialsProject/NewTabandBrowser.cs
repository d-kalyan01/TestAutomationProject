using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace SeleniumAutomation
{
    internal class NewTabandBrowser
    {
        static IWebDriver driver;

        public static void Main(string[] args)
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.way2automation.com/";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Opens new window
            driver.SwitchTo().NewWindow(WindowType.Window);
            driver.Url = "https://sso.teachable.com/secure/673/identity/sign_up/";
            Console.WriteLine(driver.Title);

            //opens new tab in same window
            driver.SwitchTo().NewWindow(WindowType.Tab);
            driver.Url = "https://demoqa.com/";
            Console.WriteLine(driver.Title);



        }
    }
}
