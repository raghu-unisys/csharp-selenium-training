using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcepts
{
    internal class Task4Day2CitiBank
    {
        public static void Main4(string[] args)
        { 
            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://www.citibank.co.in/ssjsps/forgetuseridmidssi.js";

            Thread.Sleep(3000);
            driver.Quit();
        }
    }
}
