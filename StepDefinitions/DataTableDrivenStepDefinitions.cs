using OpenQA.Selenium;
using SpecFlowProject92.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject92.StepDefinitions
{
    [Binding]
    public class DataTableDrivenStepDefinitions
    {
        private DataTableDrivenPage datatabledriven;
        private IWebDriver driver;

       public DataTableDrivenStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
            datatabledriven = new DataTableDrivenPage(driver);
        }



          [Given(@"open a browser")]
        public void GivenOpenABrowser()
        {
           
        }

        [When(@"Enter the url")]
        public void WhenEnterTheUrl()
        {
            driver.Navigate().GoToUrl("https://www.youtube.com/");
        }

        [Then(@"Enter the searchkey data you want to search")]
        public void ThenEnterTheSearchkeyDataYouWantToSearch(Table table)
        {
            datatabledriven.EnterSearchKeyData(table);
        }

    }

}
