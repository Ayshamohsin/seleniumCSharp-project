using OpenQA.Selenium;
using SpecFlowProject92.Pages;

namespace SpecFlowProject92.StepDefinitions
{
    [Binding]
    public class DataDrivenByExamplesStepDefinitionscs
    {
        private IWebDriver driver;
        private DataDrivenByExamplesPage datadrivenbyexamples;

        // Constructor to initialize WebDriver and Page Object
        public DataDrivenByExamplesStepDefinitionscs(IWebDriver driver)
        {
            this.driver = driver;
            datadrivenbyexamples = new DataDrivenByExamplesPage(driver); // Initialize the page object
        }

        // Step definition for "Given Enter the URL"
        [Given(@"Enter the URL")]
        public void GivenEnterTheURL()
        {
            driver.Navigate().GoToUrl("https://www.google.com/"); // Navigate to Google
        }

        // Step definition for "Then search with "<data>"
        [Then(@"search with ""(.*)""")]
        public void ThenSearchWith(string searchData)
        {
            datadrivenbyexamples.searchdata(searchData); // Perform search using the page method
        }
    }
}
