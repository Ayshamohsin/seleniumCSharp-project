using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject92.Pages
{

    

    public class LogIn
    {
        private IWebDriver  driver;
        public LogIn(IWebDriver driver) {
            this.driver = driver;
        }

        IWebElement UserName => driver.FindElement(By.Id("txt-username"));
        IWebElement Password => driver.FindElement(By.Id("txt-password"));
        IWebElement LoginButton => driver.FindElement (By.Id("btn-login"));

        

        public void EnterValidUserIdPassword() {
            UserName.Clear();
            UserName.SendKeys("John Doe");
            Password.Clear();
            Password.SendKeys("ThisIsNotAPassword");
        }

        public void ClickOnLoginButton()
        {
            LoginButton.Click();
        }


    }

}
