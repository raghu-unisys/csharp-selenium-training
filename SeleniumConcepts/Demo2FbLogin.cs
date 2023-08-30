using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcepts
{
    public class Demo2FbLogin
    {
        public static void Main2(String[] args)
        { 
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https:\\www.facebook.com";

            // typing the email and password by using ID of the tags
            driver.FindElement(By.Id("email")).SendKeys("john@gmail.com");
            driver.FindElement(By.Id("pass")).SendKeys("password");

            // for clicking the login button. But this is a meaningless ID so it keeps changing. So in this case the next prefrence in the name
            driver.FindElement(By.Name("login")).Click();

            driver.Quit();
        }
    }
}
