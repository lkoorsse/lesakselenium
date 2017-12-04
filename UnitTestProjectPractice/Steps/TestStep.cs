using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

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
        // public TestStep(IWebDriver _driver)


        // driver = _driver;
        //}
        //static IWebDriver driver;

        [Given(@"I browse to  '(.*)'")]
        public void GivenIBrowseTo(string url)
        {
            //driver = new ChromeDriver();
            //driver.Navigate().GoToUrl(url);

            webDriver.Navigate().GoToUrl("Https://www.google.co.uk");
        }

        

    }
}




//[Given(@"I have google open")]
    //    public void GivenIHaveGoogleOpen()
    //    {
    //        ScenarioContext.Googlepage();
    //   //    IWebDriver.Navigate().GoToUrl("http://www.google.com");
    //    }








