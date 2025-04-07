using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V129.DOM;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Assist;
using TechTalk.SpecFlow.BindingSkeletons;

namespace SpecFlowProject92.Pages
{
    public class DataTableDrivenPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;


        public DataTableDrivenPage(IWebDriver driver) {
            this.driver = driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }



        IWebElement SearchField => driver.FindElement(By.XPath("//input[@name='search_query'][1]"));

        public void EnterSearchKeyData(Table table)
        {
           var SearchCriteria = table.CreateSet<SearchEngine>();
           


            foreach (var searchingkey in SearchCriteria)
            {
                SearchField.Clear();
                SearchField.SendKeys(searchingkey.searchkey);
                SearchField.SendKeys(searchingkey.Testing);
                SearchField.SendKeys(Keys.Enter);
                Thread.Sleep(5000);
            }
           
        }
        


    }


    public class SearchEngine
    {
        public string searchkey  {  get; set; }
        public string Testing {  get; set; }
        

        
    }
}
