using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnitTestProject1.Steps
{
    [Binding]
    public class Login2Steps
    {       

        [Given(@"I have entered (.*) and (.*) in textboxes")]

        public void GivenIHaveEnteredMsantiagopcpAndTestPasswordInTextboxes(string uname, string pwd)
        {
            // ScenarioContext.Current.Pending();     
            var driver = (IWebDriver)ScenarioContext.Current["driverref"];
            driver.FindElement(By.XPath("//div[label[contains(.,'Username')]]/input[@name='username']")).SendKeys(uname);
            System.Threading.Thread.Sleep(5000);
            driver.FindElement(By.XPath("//div[label[contains(.,'Password')]]//input[@name='password']")).SendKeys(pwd);
            System.Threading.Thread.Sleep(5000);     
                   

        }
    }
}
