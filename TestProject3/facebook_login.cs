using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;



namespace TestProject3
{
    internal class facebook_login
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.facebook.com");
            //driver.Manage().Timeouts().ImplicitWait(TimeSpan.FromMilliseconds(10));
            Thread.Sleep(1000);
            IWebElement e = driver.FindElement(By.XPath("(//*[@role=\"button\"])[2]"));
            e.Click();
            Thread.Sleep(1000);
            IWebElement e1 = driver.FindElement(By.Name("firstname"));
            e1.SendKeys("bhavani");
            Thread.Sleep(1000);
            IWebElement e2 = driver.FindElement(By.Name("lastname"));
            e2.SendKeys("kota");

            /* var day = driver.FindElement(By.Id("day"));
             var select_day  = new Select Element(day);
             select_day.SelectByValue("12"); */


        }
    }
    }
