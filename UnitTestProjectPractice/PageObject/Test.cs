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

            //driver.Navigate().GoToUrl("http://www.google.com");
            //IWebElement query = driver.FindElement(By.Name("q"));
            //query.SendKeys("Hello Selenium WebDriver!");
            //query.Submit();
            //Console.WriteLine(driver.Title);

            driver.Navigate().GoToUrl("http://www.gocompare.com");

           // IWebElement carinsElement = driver.FindElement(By.CssSelector(" li.car>a:nth-child(1)>span:nth-child(1)"));
          //  carinsElement.Click();

            IWebElement element = driver.FindElement(By.CssSelector("#ctl00_phBody_ucHeroContainer_heroProductContainer > article.car.active > div > section > a.button.get-quote.car"));
            element.Click();
            IWebElement carRegElement = driver.FindElement(By.Id("AboutCarPanel_RegNumber"));
            carRegElement.SendKeys("la03tvv");

            IWebElement findCarElement =
                driver.FindElement(
                    By.CssSelector("#about-car-panel > div.question.first.carLookup-question > div:nth-child(4) > a"));
            findCarElement.Click();

            
            driver.Dispose();
        }


    }
}




