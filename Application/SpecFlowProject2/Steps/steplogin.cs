using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;


namespace SpecFlowProject2.Steps
{
    [Binding]
    public sealed class steplogin
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        public IWebDriver driver;

        public steplogin(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I lanunch the site")]
        public void GivenILanunchTheSite()
        {
            
            driver = new FirefoxDriver("./");
            //driver.Navigate();
            driver.Url = "https://localhost:44328/Home/Login";
            ScenarioContext.Current.Pending();
        }

        [Given(@"I click login link")]
        public void GivenIClickLoginLink()
        {
            driver.FindElement(By.Id("login1")).Click();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);

            ScenarioContext.Current.Pending();
        }

        [Given(@"I enter the following detals")]
        public void GivenIEnterTheFollowingDetals(Table table)
        {
            
            driver.FindElement(By.Id("name")).SendKeys("abdullah");
            driver.FindElement(By.Id("psw")).SendKeys("123");
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            ScenarioContext.Current.Pending();
        }

        [Given(@"I click login boutton")]
        public void GivenIClickLoginBoutton()
        {
            driver.FindElement(By.Id("login")).Click();
            ScenarioContext.Current.Pending();
        }

        [Then(@"go to dashebord")]
        public void ThenGoToDashebord()
        {
            driver.Url = "https://localhost:44328/Admin/Dashboard";
        
            ScenarioContext.Current.Pending();
        }
    }
}