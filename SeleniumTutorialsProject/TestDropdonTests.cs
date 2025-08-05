using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V136.Audits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SeleniumAutomation
{
    internal class TestDropdonTests
    {
        public static void Main(String[] args)
        {

            IWebDriver driver = null;
            driver = new ChromeDriver();

            driver.Url = "https://www.wikipedia.org/";
            driver.Manage().Window.Maximize();
            IWebElement dropdown = driver.FindElement(By.Id("searchLanguage"));
            SelectElement country = new SelectElement(dropdown);
            country.SelectByValue("hi");

            var options = country.Options;
            options.Count.ToString();
            Console.WriteLine("count is:" + options.Count.ToString());

            var Links = driver.FindElements(By.TagName("a"));
            Console.WriteLine("Count of Links is" + Links.Count);

          foreach (var link in Links)
            {
                Console.WriteLine(link.Text);
            }

            
            driver.Quit();
        }
    }
}
