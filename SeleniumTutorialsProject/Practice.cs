using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomation
{
    internal class Practice
    {
        static IWebDriver driver;

        public static void Main(string[] args)
        {
            driver = new ChromeDriver();
            driver.Url = "www.google.com";


            /************************** Waits **************************************************************/
            //Explicit wait
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(By.XPath("")));

            //implicit wait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Fluant Wait



            /************************* Switch To *****************************************************/
            //tabs
            IList<string> tabs = driver.WindowHandles;
            string defaultHandle = driver.CurrentWindowHandle;
            driver.SwitchTo().Window(tabs.First());

            driver.SwitchTo().Window(defaultHandle);

            //Frame
            IWebElement element= driver.FindElement(By.XPath("dropdown xpath"));
            driver.SwitchTo().Frame("abcd");
            driver.SwitchTo().Frame(element);
           
            driver.SwitchTo().DefaultContent();




            //Alert
            IAlert ialert = driver.SwitchTo().Alert();
            ialert.Accept();




            /***************************************** Screenshots  ***************************/
            //screenshot
            Screenshot screenshot = driver.TakeScreenshot();
            screenshot.SaveAsFile("//PathName");




            /*********   Dropdown **********************************************************/
            //dropdown
            IWebElement dropdown = driver.FindElement(By.XPath("dropdown xpath"));
            SelectElement select = new SelectElement(dropdown);
            select.SelectByText("player1");

            /*****************************  action class items ******************************/
            //Mouse Hover
            Actions actions = new Actions(driver);
            actions.MoveToElement(dropdown).Perform();

            //Right Click
            IWebElement webElement = driver.FindElement(By.Name("NAME"));
            Actions actions1 = new Actions(driver);
            actions1.ContextClick(webElement).Perform();

            //Drag nad Drop
            IWebElement sourceElement = driver.FindElement(By.Name(""));
            IWebElement targetElemenet = driver.FindElement(By.Name(""));
            actions.DragAndDrop(sourceElement, targetElemenet).Perform();

            //Double Click
            actions.DoubleClick(webElement).Perform();

            //Right Click
            actions.ContextClick(webElement).Perform();




        }
    }
}
