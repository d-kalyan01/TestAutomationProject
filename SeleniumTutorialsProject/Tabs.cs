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
    internal class Tabs
    {
        static IWebDriver driver;

        public static void Main(String[] args)
        {
            driver = new ChromeDriver();
            driver.Url = "https://sso.teachable.com/secure/673/identity/sign_up/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.FindElement(By.LinkText("Terms of Use")).Click();

            IList<string> windows = driver.WindowHandles;
            Console.WriteLine("count of windows:"+windows.Count);
            

            driver.FindElement(By.Id("header-sign-up-btn")).Click();
            Console.WriteLine("count of windows:" + windows.Count);
            //driver.FindElement(By.Name("sign_up_method")).Click();
            //driver.FindElement(By.Id("name")).SendKeys("Kalyan");

            driver.Close();








        }

    }
}
