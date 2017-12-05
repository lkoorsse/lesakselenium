using System;
using System.Collections.Generic;
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
    public class NavigationSteps
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
              webDriver.FindElement(By.ClassName("button get-quote car")).Click();

        }

        [Given(@"I insert '(.*)'")]
        public void GivenIInsert(string carReg)
        {

          //  .GetCarReg.Sendkeys(carReg);

            //var getCarRegField  new WaitPageObject(By.Id("AboutCarPanel_RegNumber"), 10));
            //     //     WaitPageObject.WaitForElementLoad(By.Id("AboutCarPanel_RegNumber"), 10);
            //      getCarRegField.SendKeys(carReg);
        }


        [Then(@"the car reg is popolated into the reg field")]
        public void ThenTheCarRegIsPopolatedIntoTheRegField()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I select find car")]
        public void WhenISelectFindCar()
        {
            ScenarioContext.Current.Pending();
        }

       

    }
}








