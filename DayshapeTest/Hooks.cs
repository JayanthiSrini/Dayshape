using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace DayshapeTest
{
    //Hooks used as part of Specflow

    [Binding]
    public sealed class Hooks
    {
        public static IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
           //Instantiation of chrome driver - as we are going to use chrome browser for testing
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

        }

        [AfterScenario]
        public void AfterScenario()
        {
            //To close the driver after test execution of the scenario
            driver.Quit();
            driver.Dispose();
        }
    }
}
