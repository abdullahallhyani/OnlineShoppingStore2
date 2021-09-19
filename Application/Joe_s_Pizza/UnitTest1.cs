using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace Joe_s_Pizza
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driv = new ChromeDriver();
           
            driv.Navigate().GoToUrl("http://google.com");
            //driv.FindElement(By.Name("q").SendKeys("hi");
            
        }
    }
}