using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Collections.Generic;
using NUnit.Framework;
using Microsoft.Extensions.Options;
namespace SeleniumPracticeYouTube.StepDefinitions

{
    
    [Binding]
    public sealed class RegisterStepDefinitions
    {
        private static IWebDriver driver;


        [Given(@"Open the browser")]
        public void GivenOpenTheBrowser()
        {
            if (driver != null)
            {
                driver.Url = "https://live.techpanda.org/index.php/";
            }
            else
            {
                Console.WriteLine("Driver is not initialized.");
            }

            //if (driver == null)
            //{
            //    driver = new ChromeDriver();
            //    driver.Manage().Window.Maximize();
            //}
           
        }

        [When(@"Navigate to URL")]
        public void WhenNavigateToURL()
        {
            if (driver != null)
            {
                driver.Url = "https://live.techpanda.org/index.php/";
            }
            else
            {
                Console.WriteLine("Driver is not initialized.");
            }
        }

        [When(@"Click on Register Menu")]
        public void WhenClickOnRegisterMenu()
        {
            IWebElement Account = driver.FindElement(By.ClassName("skip-account"));
            Account.Click();
            IWebElement MyAccount = driver.FindElement(By.LinkText("Register"));
            MyAccount.Click();
            Thread.Sleep(1000);
        }

        [When(@"Enter First Name as (.*)")]
        public void WhenEnterFirstNameAs(string firstname)
        {
            IWebElement FirstName = driver.FindElement(By.Id("firstname"));
            FirstName.SendKeys(firstname);
        }
        [When(@"Enter Last Name as (.*)")]
        public void WhenEnterLastNameAs(string lastname)
        {
            IWebElement LastName = driver.FindElement(By.Id("lastname"));
            LastName.SendKeys(lastname);
        }

        [When(@"Enter Email as (.*)")]
        public void WhenEnterEmailAs(string email)
        {
            Random random = new Random();
            int randomNumber = random.Next(10, 100);
            string strrandomnumber = randomNumber.ToString();

            string emailWithReplace = email.Replace("01", strrandomnumber);
            IWebElement Email = driver.FindElement(By.Id("email_address"));
            Email.SendKeys(emailWithReplace);
        }

        [When(@"Enter Password as (.*)")]
        public void WhenEnterPasswordAs(string password)
        {
            IWebElement Password = driver.FindElement(By.Id("password"));
            Password.SendKeys(password);
        }

        [When(@"Enter Confirm Password as (.*)")]
        public void WhenEnterConfirmPasswordAs(string Confirmpassword)
        {
            IWebElement ConfirmPassword = driver.FindElement(By.Id("confirmation"));
            ConfirmPassword.SendKeys(Confirmpassword);
        }

        [When(@"Click on Register Button")]
        public void WhenClickOnRegisterButton()
        {
            IWebElement RegisterButton = driver.FindElement(By.XPath("//button[@title='Register']"));
            RegisterButton.Click();
        }

        [Then(@"Message is displayed as (.*)")]
        public void ThenMessageIsDisplayedAs(string message) 
        {
            IWebElement Message = driver.FindElement(By.XPath(".//li[@class='success-msg']/ul/li/span"));
            string UIMessage=Message.Text;
             Assert.AreEqual(message, UIMessage);
        }
    }
}
