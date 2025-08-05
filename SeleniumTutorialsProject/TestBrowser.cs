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
    internal class TestBrowser
    {
        static string BrowserName = "Chrome";
        static IWebDriver driver;
        public static void Main(string[] args)
        {

            switch (BrowserName)
            {

                case "Chrome":
                    driver = new ChromeDriver();
                    break;
                case "Firefox":
                    driver = new FirefoxDriver();
                    break;
                case "Edge":
                    driver = new EdgeDriver();
                    break;
            }

            if (driver == null)
            {
                Console.WriteLine("Browser not supported.");
                return;
            }
            else
            {
                driver.Navigate().GoToUrl("https://www.gmail.com");
                driver.Manage().Window.Maximize();
                driver.FindElement(By.Id("identifierId")).SendKeys("java@way2automation.com");
                driver.FindElement(By.XPath("//span[contains(text(),'Next')]")).Click();
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                wait.Until(ExpectedConditions.ElementToBeClickable(By.Name("Passwd")));
                driver.FindElement(By.Name("Passwd")).SendKeys("Kalyan@1994");
                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(text(),'Next')]"))).Click();
                
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[contains(text(),'Wrong password. Try again or click Forgot password to reset it.')]")));
                string error = driver.FindElement(By.XPath("//span[contains(text(),'Wrong password. Try again or click Forgot password to reset it.')]")).Text;
                Assert.AreEqual("Wrong password. Try again or click Forgot password to reset it.", error);

                driver.Quit();

            }







        }

    }
}

