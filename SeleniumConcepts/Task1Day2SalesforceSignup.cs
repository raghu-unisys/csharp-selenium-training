using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcepts
{
    internal class Task1Day2SalesforceSignup
    {
        public static void Main(string[] args)
        {
            IWebDriver driver = new EdgeDriver();

            // Task 1 - Day - 1 SalesForce Assignment
            driver.Url = "https://www.salesforce.com/in/form/signup/freetrial-sales/";
            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            // entering the first and last name

            driver.FindElement(By.Name("UserFirstName")).SendKeys("John");
            driver.FindElement(By.Name("UserLastName")).SendKeys("Wick");
            driver.FindElement(By.Name("UserEmail")).SendKeys("john@gmail.com");
            SelectElement selectJobTitle = new SelectElement(driver.FindElement(By.Name("UserTitle")));
            selectJobTitle.SelectByText("IT Manager");
            driver.FindElement(By.Name("UserLastName")).SendKeys("Wick");
            driver.FindElement(By.Name("CompanyName")).SendKeys("Unisys");
            SelectElement selectEmployees = new SelectElement(driver.FindElement(By.Name("CompanyEmployees")));
            selectEmployees.SelectByText("101 - 200 employees");

            // clicking the check box and submitting

            driver.FindElement(By.ClassName("checkbox-ui")).Click();
            driver.FindElement(By.Name("start my free trial")).Click();

            SelectElement selectCountry = new SelectElement(driver.FindElement(By.Name("CompanyCountry")));
            selectCountry.SelectByText("United Kingdom");



            // how to click away from the green box ?


            // getting the error message
            string message = driver.FindElement(By.XPath("//span[contains(@id,'UserPhone')]")).Text;

            Console.WriteLine("The message shown : " + message);

            Thread.Sleep(2000);
            driver.Quit();
        }
    }
}
