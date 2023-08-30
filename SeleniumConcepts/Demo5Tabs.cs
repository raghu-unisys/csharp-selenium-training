using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcepts
{
    internal class Demo5Tabs
    {
        public static void Main5(string[] args)
        {
            // In this we will be learning to close and open multiple tabs

            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.db4free.net";

            // clicking on phpMyAdmin
            driver.FindElement(By.XPath("//a[contains(@href,'/phpMyAdmin')]")).Click();

            // printing the session ID of the tab, this returns a collection of strings
            Console.WriteLine(driver.WindowHandles[0]);
            Console.WriteLine(driver.WindowHandles[1]);

            // switching to a session ID of second tab, now the driver will have control of second tab
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            // now filling user and password
            driver.FindElement(By.Id("input_username")).SendKeys("admin");
            driver.FindElement(By.Id("input_password")).SendKeys("welcome123");
            driver.FindElement(By.Id("input_go")).Click();
            

            // displaying the error message
            string actualError = driver.FindElement(By.Id("pma_errors")).Text;
            Console.WriteLine("Error message displayed : " + actualError);

            // closing the current tab
            driver.Close();

            // printing the title of the current tab, for this we should switch to the aviable tab
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            Console.WriteLine(driver.Title);


            Thread.Sleep(3000);
            driver.Quit();

        }
    }
}
