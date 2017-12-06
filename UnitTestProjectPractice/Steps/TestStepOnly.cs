﻿using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using UnitTestProjectPractice.PageObject;

namespace TestProjectPractice
{
    [Binding]
    public class TestStepOnly
    {

       
        private IWebDriver webDriver;

        [BeforeScenario]
        public void InitScenario()
        {
            webDriver = new ChromeDriver();
           
        }

        [AfterScenario]
        public void TearDownScenario()
        {
            webDriver.Dispose();
        }


        [Given(@"I browse to  '(.*)'")]
        public void GivenIBrowseTo(string url)
        {


            webDriver.Navigate().GoToUrl("Https://www.gocompare.com");
        }

        [Given(@"I select get quote")]
        public void GivenISelectGetQuote()
        {
            webDriver.FindElement(By.CssSelector("a.home")).Click();

        }

        [Given(@"I insert '(.*)'")]
        public void GivenIInsert(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I select find car")]
        public void WhenISelectFindCar()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the car reg is popolated into the reg field")]
        public void ThenTheCarRegIsPopolatedIntoTheRegField()
        {
            ScenarioContext.Current.Pending();
        }



    }
}








