 using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V131.Page;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject92.Pages
{
   public class DataDrivenByExamplesPage
    {
        private WebDriverWait wait;  
        private IWebDriver driver;
        

        public DataDrivenByExamplesPage(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        IWebElement EnterSearchKey => driver.FindElement(By.XPath("//textarea[@id ='APjFqb']"));

        public void searchdata(string data)
        {
            EnterSearchKey.Click();
            EnterSearchKey.SendKeys(data);
            EnterSearchKey.SendKeys(Keys.Enter);
            Thread.Sleep(1000);

        }


    }
}
