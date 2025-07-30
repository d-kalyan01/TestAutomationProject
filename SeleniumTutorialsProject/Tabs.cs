using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SeleniumAutomation
{
    internal class Tabs
    {
        static IWebDriver driver;

        public static void Main(string[] args)
        {
            driver = new ChromeDriver();
            driver.Url = "https://sso.teachable.com/secure/673/identity/sign_up/";
            driver.Manage().Window.Maximize();

            IList<string> windhandle = driver.WindowHandles;
            Console.WriteLine("total windows:" + windhandle.Count);
            driver.FindElement(By.LinkText("Privacy Policy")).Click();


            windhandle = driver.WindowHandles;
            Console.WriteLine("total windows:"+ windhandle.Count);

            driver.SwitchTo().Window(windhandle[1]);
            //button on next window
            driver.FindElement(By.Id("header-sign-up-btn")).Click();

             windhandle = driver.WindowHandles;
            Console.WriteLine("total windows:" + windhandle.Count);

            driver.SwitchTo().Window(windhandle[0]);
            //button on main page
            driver.FindElement(By.Name("sign_up_method")).Click();

            driver.Close();



        }

    }
}
