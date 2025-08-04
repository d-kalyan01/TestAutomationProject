using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;

namespace SeleniumTutorialsProject
{
    internal class ScreenshotTest
    {
        static IWebDriver driver;

        public static void Main(string[] args)
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.google.com/";
            driver.Manage().Window.Maximize();

            Console.WriteLine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent);
            IWebElement element = driver.FindElement(By.XPath("//div[@class='FPdoLc lJ9FBc']//input[@name='btnK']"));


            //take screenshot of perticular element
            Screenshot screenshot = ((ITakesScreenshot)element).GetScreenshot();
            screenshot.SaveAsFile((Directory.GetParent(Environment.CurrentDirectory).Parent.Parent) + "\\Screenshots\\error.jpg");




        }
    }
}
