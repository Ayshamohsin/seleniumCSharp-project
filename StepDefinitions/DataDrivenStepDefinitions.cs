using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V131.DeviceAccess;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SpecFlowProject92;
using SpecFlowProject92.Pages;

namespace SpecFlowProject92.StepDefinitions
{
    [Binding]
    public sealed class DataDrivenStepDefinitions
    {
        private IWebDriver driver;
        private DataDrivenPage datadrivenpage;

        public DataDrivenStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
            datadrivenpage = new DataDrivenPage(driver);
        }




        [Given(@"the user logs in for datadriven with ""([^""]*)"" and ""([^""]*)""")]
        public void GivenTheUserLogsInForDatadrivenWithAnd(string id, string password)
        {
            driver.Navigate().GoToUrl("https://katalon-demo-cura.herokuapp.com/profile.php#login");
            driver.FindElement(By.Id("txt-username")).SendKeys("John Doe");
            driver.FindElement(By.Id("txt-password")).SendKeys("ThisIsNotAPassword");
            driver.FindElement(By.Id("btn-login")).Click();

        }



        [Then(@"user entered the data '([^']*)'")]
        public void ThenUserEnteredTheData(string enterdata)
        {
            datadrivenpage.CreateAnAppointment(enterdata);
        }



    }
}



      