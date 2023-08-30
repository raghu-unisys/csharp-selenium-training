using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcepts
{
    internal class Demo3SignUp
    {
        public static void Main3(string[] args)
        {
            // webdriver
            IWebDriver driver = new ChromeDriver();

            driver.Url = "https:\\www.facebook.com";

            // clicking on signup
            //driver.FindElement(By.Id("signup-button")).Click();
            driver.FindElement(By.LinkText("Create new account")).Click();

            // Maximising the browser
            driver.Manage().Window.Maximize();

            // Adding some wait time for all the elements to be loaded
            //Thread.Sleep(7000);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            // filling the details. FindElement method will only take 0.5 seconds to find the element. If the elements are all not loaded we will need to wait
            driver.FindElement(By.Name("firstname")).SendKeys("John");
            driver.FindElement(By.Name("lastname")).SendKeys("Wick");
            driver.FindElement(By.Name("reg_email__")).SendKeys("john@gmail.com");
            driver.FindElement(By.Name("reg_email_confirmation__")).SendKeys("john@gmail.com");
            driver.FindElement(By.Id("password_step_input")).SendKeys("welcome123");

            // Entering the date of birth. This is a drop down, with select elements and without select element
            /*
            driver.FindElement(By.Id("day")).SendKeys("20");
            driver.FindElement(By.Id("month")).SendKeys("Dec");
            driver.FindElement(By.Id("year")).SendKeys("2000");
            */
            SelectElement selectDay = new SelectElement(driver.FindElement(By.Id("day")));
            selectDay.SelectByText("20");
            SelectElement selectMonth = new SelectElement(driver.FindElement(By.Id("month")));
            selectMonth.SelectByText("Dec");
            SelectElement selectYear = new SelectElement(driver.FindElement(By.Id("year")));
            selectYear.SelectByText("2000");


            // clicking the radio button for gender. Since they dont have any unique attributes other than value we will use XPath
            driver.FindElement(By.XPath("//input[@value='2']")).Click();
            //driver.FindElement(By.XPath("//text[@value='2']")).Click();

            // Submitting the form
            driver.FindElement(By.Name("websubmit")).Click();


            // clicking on next, in this there in no ID, the class will have comman names. We will be using link text for this as it is an anchor tag

            

            Thread.Sleep(2000);
            driver.Quit();
        }
    }
}
