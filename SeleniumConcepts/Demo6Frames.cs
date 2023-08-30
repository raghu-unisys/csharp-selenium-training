using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcepts
{
    internal class Demo6Frames
    {
        public static void Main6(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            // navigating to HDFC 
            driver.Url = "https://netbanking.hdfcbank.com/netbanking/";

            // entering the username. In this case the whole window is inside a frame. So we need to get into the frame
            //driver.SwitchTo().Frame(driver.FindElement(By.XPath("//frame[@name='login_page']")));
            driver.SwitchTo().Frame("login_page");
            driver.FindElement(By.Name("fldLoginUserId")).SendKeys("jack123");
            driver.FindElement(By.XPath("//a[contains(text(),\"CONTINUE\")]")).Click();
            driver.FindElement(By.Id("fldPasswordDispId")).SendKeys("welcome123");


            // switching back to the main frame
            driver.SwitchTo().DefaultContent();

            Thread.Sleep(3000);
            driver.Close();
        }
    }
}
