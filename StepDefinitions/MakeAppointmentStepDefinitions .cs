using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V131.DeviceAccess;
using OpenQA.Selenium.Support.UI;
using SpecFlowProject92;
using SpecFlowProject92.Pages;

namespace SpecFlowProject92.StepDefinitions
{
    [Binding]
    public sealed class MakeAppointmentStepDefinitions
    {
        private IWebDriver driver;
        private MakeAppointmentPage makeappointmentpage;

        public MakeAppointmentStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
            makeappointmentpage = new MakeAppointmentPage(driver);
    }
        
        [Given(@"the user logs in with ""([^""]*)"" and ""([^""]*)""")]
        public void GivenTheUserLogsInWithAnd(string p0, string password)
        {
            driver.Navigate().GoToUrl ("https://katalon-demo-cura.herokuapp.com/profile.php#login");
            driver.FindElement(By.Id("txt-username")).SendKeys("John Doe");
            driver.FindElement(By.Id("txt-password")).SendKeys("ThisIsNotAPassword");
            driver.FindElement(By.Id("btn-login")).Click();

        }



        [When(@"User creats an appointment with:")]
        public void WhenUserCreatsAnAppointmentWith(Table table)
        {
            makeappointmentpage.SetDynamicValuesToDynamicVariables(table);
        }

        [Then(@"the appointment should be created successfully")]
        public void ThenTheAppointmentShouldBeCreatedSuccessfully()
        {
            

        }

        /////// TESTING Background statement PURPOSE ///////

        [Given(@"User login to thee system")]
        public void GivenUserLoginToTheeSystem()
        {
        }

        [When(@"User created an appointment with:")]
        public void WhenUserCreatedAnAppointmentWith(Table table)
        {
            makeappointmentpage.SetDynamicValuesToDynamicVariables(table);
        }

        [Then(@"Appointment should be created successfully")]
        public void ThenAppointmentShouldBeCreatedSuccessfully()
        {
           
        }



    }
}
    
