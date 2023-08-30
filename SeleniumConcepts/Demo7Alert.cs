using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace SeleniumConcepts
{
    internal class Demo7Alert
    {
        public static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://netbanking.hdfcbank.com/netbanking/IpinResetUsingOTP.htm";

            // clicking on go
            driver.FindElement(By.XPath("//img[@alt='Go']")).Click();

            // switching the control to the alert box
            string alertText = driver.SwitchTo().Alert().Text;

            // closing the alert box
            driver.SwitchTo().Alert().Accept();

            // going to nasscom membership
            driver.Url = "https://nasscom.in/nasscom-membership";
            driver.FindElement(By.Id("calculate-fee")).Click();
            Console.WriteLine("Alert text : " + driver.SwitchTo().Alert().Text);
            driver.SwitchTo().Alert().Accept();

            driver.SwitchTo().DefaultContent();

            driver.Quit();
        }
    }
}
