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
    internal class TestAlert
    {
        static IWebDriver driver;
        public static void Main(string[] args)
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://mail.rediff.com/cgi-bin/login.cgi");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.ClassName("signin-btn")).Click();


            IAlert alert = driver.SwitchTo().Alert(); // Accept the alert
            Console.WriteLine("alert message  " + alert.Text);
            alert.Accept(); // Accept the alert to close it
            
        }


    }
}
