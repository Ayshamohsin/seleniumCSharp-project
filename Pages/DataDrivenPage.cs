using Gherkin.Ast;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;

namespace SpecFlowProject92.Pages
{
    public class DataDrivenPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        public DataDrivenPage(IWebDriver driver)
        {
            this.driver = driver;
            //Implicit Timeout
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //Explicit wait Timeout
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        }



        IWebElement FacilityDropDown => driver.FindElement(By.Id("combo_facility"));
        IWebElement CheckBox => driver.FindElement(By.Id("chk_hospotal_readmission"));
        IWebElement RadioButton => wait.Until(ExpectedConditions.ElementIsVisible(By.Id("radio_program_medicaid")));
        IWebElement Calender => driver.FindElement(By.XPath("//span[@class='glyphicon glyphicon-calendar']"));
        IWebElement Comment => wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("txt_comment")));
        IWebElement BookAppointment => driver.FindElement(By.Id("btn-book-appointment"));




        public void SelectDate(string TargetDate)
        {
           
            DateTime DesiredDate = DateTime.Parse(TargetDate);
            while (true)
            {
                // Find the currently displayed month and year in the calendar
                var ActualDate = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//th[@class='datepicker-switch']"))).Text; // January 2025
                // Parse the displayed date into a DateTime object                                                                                                                       // Parse the displayed date into a DateTime object
                DateTime ActualDisplayedDate = DateTime.Parse("01 " + ActualDate);  // Parses like "01 January 2025"
                // Compare the displayed date with the desired date
                if (ActualDisplayedDate.Year == DesiredDate.Year && ActualDisplayedDate.Month == DesiredDate.Month)
                {
                    break;
                }

                if (ActualDisplayedDate < DesiredDate)
                {
                    // Navigate to the next month if the desired date is in the future
                    wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//th[@class='next']"))).Click();

                }
                else
                {
                    // Navigate to the previous month if the desired date is in the past
                    wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//th[@class='prev']"))).Click();
                }
            }

            // Once the correct month and year are displayed, select the desired day
            var days = driver.FindElements(By.XPath("//td[@class='day']"));
            foreach (var day in days)
            {
                if (day.Text == DesiredDate.Day.ToString()) // Compare the day number
                {
                    day.Click(); // Click the desired day
                    break;
                }
            }
        }








            public void CreateAnAppointment(string enterdata)
            {
                FacilityDropDown.Click();
                SelectElement select = new SelectElement(FacilityDropDown);
                select.SelectByValue("Seoul CURA Healthcare Center");
                CheckBox.Click();
                RadioButton.Click();
                Calender.Click();
                SelectDate("2023-02-15");
                Comment.Click();
                Comment.SendKeys(enterdata);
                Thread.Sleep(10000);
                BookAppointment.Click();

            }


        }
    }

