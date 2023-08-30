using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V113.DOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unisys.SeleniumConcepts2
{
    public class SeleniumAdvanceTest
    {
        // when we create a console app we will get .exe file but in unit test project doesnt have an exe file

        // in test project there in no main method. we will have to create methods that we can trigger. The [Test] is a test attribute and this will make the method into a test method
        [Test]
        public void UploadTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Url = "https://www.ilovepdf.com/pdf_to_word";

            // uploading the file
            driver.FindElement(By.XPath("//input[@type='file']")).SendKeys(@"C:\Users\RRaghuna\Downloads\VENDBILL1308.pdf");
            /*
                Alternate XPaths
                //input[@type='file] using and
            */

            Thread.Sleep(3000);
            driver.Quit();
        }
    }   
}
