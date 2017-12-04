using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using TechTalk.SpecFlow;


namespace UnitTestProjectPractice
{
    public class Navigation
    {

        IWebDriver driver = new ChromeDriver();


        [Test]
        public void navigation()
        {

            driver.Navigate().GoToUrl("http://www.google.com");

            //Assert.AreEqual("SW Test Academy - Software Test Academy", driver.Title);
            // driver.Close();
            //driver.Quit();

        }
    }
}
//{
        //private IWebDriver webDriver;

        //[BeforeScenario]
        //public void InitScenario()
        //{ webDriver = new ChromeDriver(); }

        //[AfterScenario()]
        //public void TearDownScenario()
        //{ webDriver.Dispose();}
      
            
         //    { IWebDriver driver = new ChromeDriver(); }



    //}

//}


//    [TestClass]
//    public class Test
//    {
//        private static IWebDriver driverGC;
//    }

//    [AssemblyInitialize]
//    public static void SetUp(TestContext context)
//    {
//    driverGC = new ChromeDriver(@"c:\dev\UnitTestProjectPractice\chromedriver");
//    }


//    [TestMethod]
//    public void TestChromeDriver()
//    {

//    driverGC.Navigate().GoToUrl("");
//    driverGC.FindElement(By.Id("lst-ib")).SendKeys("Selenium");
//        driverGC.FindElement(By.Id("lst-ib")).SendKeys(Keys.Enter);

//    }
//}





