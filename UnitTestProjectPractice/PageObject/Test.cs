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
            IWebElement query = driver.FindElement(By.Name("q"));
            query.SendKeys("Hello Selenium WebDriver!");
            query.Submit();
            Console.WriteLine(driver.Title);

        }


    }
}




