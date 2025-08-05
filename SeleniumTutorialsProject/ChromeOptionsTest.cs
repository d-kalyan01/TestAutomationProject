using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTutorialsProject
{
    internal class ChromeOptionsTest
    {

        static IWebDriver driver;

        public static void Main(string[] args)
        {
            ChromeOptions Options = new ChromeOptions();
            Options.AddArgument("--headless");
            driver = new ChromeDriver(Options);
            driver.Url = "https://www.google.com/";
            driver.Manage().Window.Maximize();

            Console.WriteLine(driver.Title);
            
        }
    }
}
