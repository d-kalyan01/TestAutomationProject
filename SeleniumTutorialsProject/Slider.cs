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
    internal class Slider
    {
        static IWebDriver driver;

        public static void Main(string[] args)
        {
            driver = new ChromeDriver();
            driver.Url = "https://jqueryui.com/slider/";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Switch to the frame containing the slider
            driver.SwitchTo().Frame(driver.FindElement(By.CssSelector(".demo-frame")));

            // Find the slider handle element
            IWebElement sliderHandle = driver.FindElement(By.ClassName("ui-slider-handle"));

            Actions actions = new Actions(driver);

            // Move the slider handle by an offset (e.g., 0 on Y, 100 on X)
            actions.DragAndDropToOffset(sliderHandle, 100, 0).Perform();
        }
    }


}

