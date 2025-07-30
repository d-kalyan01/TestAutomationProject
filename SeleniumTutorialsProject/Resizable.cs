using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace SeleniumAutomation
{
    internal class Resizable
    {

        static IWebDriver driver;
        public static void Main(string[] args)
        {
            driver = new ChromeDriver();
            driver.Url = "https://jqueryui.com/resizable/";
            driver.Manage().Window.Maximize();

            IWebElement frame = driver.FindElement(By.ClassName("demo-frame"));
            driver.SwitchTo().Frame(frame);

            IWebElement resize=driver.FindElement(By.Id("resizable"));

            Actions action = new Actions(driver);
            Thread.Sleep(1000);
            action.DragAndDropToOffset(resize, 5, 50).Perform();
            Thread.Sleep(1000);
            driver.Close();


        }

    }
}
