using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using System;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            
            IWebDriver driver = new FirefoxDriver("./");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
  
            driver.Url = "https://localhost:44328/Home/Index/";
            

            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("1")).Click();
            
            driver.FindElement(By.Id("dropdown")).Click();
           
            driver.FindElement(By.Id("Checkout")).Click(); 
            
            driver.FindElement(By.Id("CheckoutDetails")).Click();
            driver.FindElement(By.Id("name")).SendKeys("abdullah");
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);

            driver.FindElement(By.Id("CardNumber")).SendKeys("SA9020000000387992");
            
            driver.FindElement(By.Id("cvv")).SendKeys("012");
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("Payment")).Click();
            



            //driver.FindElement(By.LinkText("customerLoginPage"));
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            //driver.FindElement(By.Id("Email")).SendKeys("abdullah.s.allhyani@gmail.com");
            //driver.FindElement(By.Id("Password")).SendKeys("Aa123456");
            //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            //driver.FindElement(By.CssSelector("js-loginSubmit")).Submit();
           // driver.FindElement(By.CssSelector("btn btn--small js-loginSubmit")).Click();
            





        }
}
}
