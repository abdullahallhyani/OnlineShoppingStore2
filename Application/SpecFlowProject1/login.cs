using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;



namespace SpecFlowProject1
{
    class login
    {

       




        public IWebDriver webDriver { get; }

        public login (IWebDriver webDriver) {
            webDriver = webDriver;
        }
        public IWebDriver lnkLogin => (IWebDriver)webDriver.FindElement(By.LinkText("customerLoginPage"));
        public IWebDriver txtUserName => (IWebDriver)webDriver.FindElement(By.Name("Email"));
        public IWebDriver txtPassword => (IWebDriver)webDriver.FindElement(By.Name("Password"));
        public IWebDriver btnLogin => (IWebDriver)webDriver.FindElement(By.CssSelector("btn btn--small js-loginSubmit"));


        public void ClickLogin()
        {
            lnkLogin.Click();
        }
        public void Login(string txtUserName, string txtPassword) {
            txtUserName.SendKeys(txtUserName);
                }



        //https://www.dominos.sa/ar/pages/customer/#!/customer/login/




    }
}
