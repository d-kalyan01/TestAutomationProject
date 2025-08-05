using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumPracticeYouTube.Utility;
using System.ComponentModel;
using System.Net.NetworkInformation;
using TechTalk.SpecFlow;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports;

namespace SeleniumPracticeYouTube.Hooks
{
    [Binding]
    public sealed class Hooks : ExtentReport
    {
        private static IWebDriver driver;
        IObjectContainer _container;
        public Hooks(IObjectContainer container)
        {
            _container = container;
        }

        [BeforeTestRun]
        public static void  BeforeTestRun()
        {
            Console.WriteLine("Running Before Test Run...");
            ExtentReportInit();

        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            if (driver != null)
            {
                driver.Quit();
                driver = null;
            }
            Console.WriteLine("Running after Test Run....");
            ExtentReportTearDown();
        }






        [BeforeScenario(Order = 1)]
        public static void BeforeScenario(ScenarioContext scenarioContext)
        {
            Console.WriteLine("Running Before scenario...");
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }


        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            Console.WriteLine("Running before feature...");
            _feature = _extentReports.CreateTest<Feature>(featureContext.FeatureInfo.Title);

        }

        [AfterFeature]
        public static void AfterFeatureRun()
        {

            Console.WriteLine("Running after feature..");

        }


        [BeforeScenario("@Testers")]
        public static void BeforeScenarioWithTag()
        {
            Console.WriteLine("Running inside tagged hooks in specflow..");
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            _container.RegisterInstanceAs<IWebDriver>(driver);
            _scenario = _feature.CreateNode<Scenario>("Running before scenario...");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            var driver = _container.Resolve<IWebDriver>();
            if (driver != null)
            {
                driver.Quit();
            }

        }


        [AfterStep]
        public void AfterStep(ScenarioContext scenarioContext)
        {


            Console.WriteLine("Running after step...");
            string stepType = scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString();
            string stepName = scenarioContext.StepContext.StepInfo.Text;
            var driver = _container.Resolve<IWebDriver>();

            //when scenario passed
            if (scenarioContext.TestError == null)
            {

                if (stepType == "Given")
                {
                    _scenario.CreateNode<Given>(stepName);
                }
                else if (stepType == "When")
                {
                    _scenario.CreateNode<When>(stepName);
                }
                else if (stepType == "Then")
                {
                    _scenario.CreateNode<Then>(stepName);
                }
            }

            //when scenario failed
            if (scenarioContext.TestError != null)
            {

                addScreenshot(driver,scenarioContext);
                if (stepType == "Given")
                {
                    _scenario.CreateNode<Given>(stepName).Fail(scenarioContext.TestError.Message,MediaEntityBuilder.CreateScreenCaptureFromPath(addScreenshot(driver, scenarioContext)).Build());
                }
                else if (stepType == "When")
                {
                    _scenario.CreateNode<When>(stepName).Fail(scenarioContext.TestError.Message, MediaEntityBuilder.CreateScreenCaptureFromPath(addScreenshot(driver, scenarioContext)).Build());
                }
                else if (stepType == "Then")
                {
                    _scenario.CreateNode<Then>(stepName).Fail(scenarioContext.TestError.Message, MediaEntityBuilder.CreateScreenCaptureFromPath(addScreenshot(driver, scenarioContext)).Build());
                }

            }
        }
    }
}