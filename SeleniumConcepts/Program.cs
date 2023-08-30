using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unisys.SeleniumConcepts
{
    public class Program
    {
        public static void Main1(string[] args) 
        {
            IWebDriver obj = new ChromeDriver();
            obj.Url = "https://www.salesforce.com/in/form/signup/freetrial-sales/";
            Console.WriteLine(obj.Title);
            Console.WriteLine(obj.PageSource);

            obj.Quit();

            obj = new EdgeDriver();
            obj.Url = "https://www.salesforce.com/in/form/signup/freetrial-sales/";
            obj.Quit();
        }
    }
}
