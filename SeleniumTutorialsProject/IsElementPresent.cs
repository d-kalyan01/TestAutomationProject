using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTutorialsProject
{
    internal class IsElementPresent
    {


        static IWebDriver driver;

        public static void Main(string[] args)
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.google.com/";
            driver.Manage().Window.Maximize();

            Console.WriteLine(isElementPresent(By.Name("abcd")));
            Console.WriteLine(isElementPresent(By.XPath("//div[@class='FPdoLc lJ9FBc']//input[@name='btnK']")));

        }

        static bool isElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

    }
}
