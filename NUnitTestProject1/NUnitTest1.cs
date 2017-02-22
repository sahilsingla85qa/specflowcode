﻿using System;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System.Threading;

namespace NUnitTestProject1
{
   

   
    [TestFixture(typeof(OpenQA.Selenium.Chrome.ChromeDriver))]
    [TestFixture(typeof(FirefoxDriver))]
    public class NUnitTest1<TWebDriver> where TWebDriver : IWebDriver, new()
    {
        public IWebDriver driver=null;


        [Test]
        public void TestMethod1()
        {
            
            driver.Navigate().GoToUrl("http://www.google.com/");
            IWebElement query = driver.FindElement(By.Name("q"));
            query.SendKeys("Bread" + Keys.Enter);

            Thread.Sleep(2000);

            Assert.AreEqual("bread - Google Search", driver.Title);
            driver.Quit();


        }

        
    }



}