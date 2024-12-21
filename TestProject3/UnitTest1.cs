using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject3
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://practice.bpbonline.com";
            driver.Manage().Window.Maximize();
            driver.FindElement(By.LinkText("My Account")).Click();
            driver.FindElement(By.LinkText("Continue")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@value=\"f\"]")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Name("firstname")).SendKeys("kota");
            Thread.Sleep(1000);
            driver.FindElement(By.Name("lastname")).SendKeys("bhavani");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("dob")).SendKeys("12/08/1995");
            Thread.Sleep(1000);

            /* driver.FindElement(By.Id("dob")).Click();
            Thread.Sleep(1000); */
            /* driver.FindElement(By.LinkText("Aug")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//option[@value=\"1995\"]")).Click();
            Thread.Sleep(1000); */
            driver.FindElement(By.Name("email_address")).SendKeys("bhavani.kota213@gmail.com");
            Thread.Sleep(1000);
            driver.FindElement(By.Name("company")).SendKeys("oakya it services");
            Thread.Sleep(1000);
            driver.FindElement(By.Name("street_address")).SendKeys("ramalayam street");
            Thread.Sleep(1000);
            driver.FindElement(By.Name("suburb")).SendKeys("ganapavarigudem");
            Thread.Sleep(1000);


            driver.FindElement(By.Name("postcode")).SendKeys("534462");
            Thread.Sleep(1000);
            driver.FindElement(By.Name("city")).SendKeys("eluru");
            Thread.Sleep(1000);
            driver.FindElement(By.Name("state")).SendKeys("andhrapradesh");
            Thread.Sleep(1000);


            driver.FindElement(By.XPath("//*[@name=\"country\"]")).Click();
            driver.FindElement(By.XPath("//option[@value=\"99\"]")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Name("telephone")).SendKeys("8332928318");
            Thread.Sleep(1000);
            driver.FindElement(By.Name("fax")).SendKeys("1234");
            Thread.Sleep(1000);


                         driver.FindElement(By.XPath("//*[@name=\"newsletter\"]")).Click();
                         Thread.Sleep(1000);
                             driver.FindElement(By.XPath("//input[@type=\"password\"][1]")).SendKeys("bhavani123");
                             Thread.Sleep(1000);
                        driver.FindElement(By.Name("confirmation")).SendKeys("bhavani123");
                        Thread.Sleep(1000);
                             driver.FindElement(By.XPath("(//*[@class=\"ui-button-text\"])[4]")).Click();
                              Thread.Sleep(1000);
                     driver.Close();








        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}