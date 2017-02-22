using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace NUnitTestProject1.Steps
{
    [Binding]
    public class LoginSteps
    {
        public IWebDriver webdriver;

        [BeforeScenario]

        public void initscenario()
        {
            webdriver = new ChromeDriver();
            
        }

        [AfterScenario]

        public void TearDownScenario()
        {
            webdriver.Dispose();

        }

        [Given(@"I am on the Login page")]
        public void GivenIAmOnTheLoginPage()
        {
           //ScenarioContext.Current.Pending();

            webdriver.Navigate().GoToUrl("https://demo.innovamd.com/#/landing");
            System.Threading.Thread.Sleep(5000);

            ScenarioContext.Current.Add("driverref", webdriver);
        }
        
        [Given(@"Enter wrong username and password")]
        public void GivenEnterwrongusernameandpassword()
        {
            //ScenarioContext.Current.Pending();
            webdriver.FindElement(By.XPath("//div[label[contains(.,'Username')]]/input[@name='username']")).SendKeys("sfjdshf");
            System.Threading.Thread.Sleep(5000);
            webdriver.FindElement(By.XPath("//div[label[contains(.,'Password')]]//input[@name='password']")).SendKeys("sfjdshf");
            System.Threading.Thread.Sleep(5000);
            

        }
        
        [When(@"I press login button")]
        public void WhenIPressLoginButton()
        {
             //ScenarioContext.Current.Pending();

            webdriver.FindElement(By.XPath("//button[contains(.,'Login')]")).Click();
            System.Threading.Thread.Sleep(7000);
        }
        
        [Then(@"the result should be validation message")]
        public void ThenTheResultShouldBeValidationMessage()
        {
            //ScenarioContext.Current.Pending();          

            webdriver.FindElement(By.XPath("//button[text()='OK']")).Click();
            System.Threading.Thread.Sleep(7000);
        }
    }
}
