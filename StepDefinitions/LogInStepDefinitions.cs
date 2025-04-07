using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowProject92.Pages;

namespace SpecFlowProject92.StepDefinitions
{
    [Binding]
    public sealed class LoginStepDefinitions
    {
      private IWebDriver driver;
      private LogIn login;

        public LoginStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
            login = new LogIn (driver);
        }


        [Given(@"open the browser")]
        public void GivenOpenTheBrowser()
        {
          
        }

        [Given(@"Navigate to Login Page")]
        public void GivenNavigateToLoginPage()
        {
         
            driver.Url = ("https://katalon-demo-cura.herokuapp.com/profile.php#login");
            Thread.Sleep(6000);
        }

        [When(@"User entered valid user id and password")]
        public void EnterValidUserIdPassword()
        {
            login.EnterValidUserIdPassword();
        }

        [When(@"Hit login button")]
        public void WhenHitLoginButton()
        {
            login.ClickOnLoginButton();
            
        }

        [Then(@"User should be redirected to the homepage")]
        public void ThenUserShouldBeRedirectedToTheHomepage()
        {
            Thread.Sleep(6000);
           
        }

    }
}
