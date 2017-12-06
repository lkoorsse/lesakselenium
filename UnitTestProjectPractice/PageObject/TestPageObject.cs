using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using UnitTestProjectPractice.WrapperFactory;

namespace UnitTestProjectPractice.PageObject
{

    public interface ITestPageObject
    {

        IWebElement Url { get; set; }
        IWebElement QuoteButton { get; set; }
        IWebElement SearchField { get; set; }
        IWebElement SetYes { get; set; }
        void CarRegField(string carReg);
    }


   public class TestPageObject : Page, ITestPageObject
    {

     
        public TestPageObject(IWebDriver driver) : base(driver)
        {
           
        }

        [FindsBy(How = How.Id, Using = "")]
        public IWebElement Url { get; set; }

        public IWebElement QuoteButton { get; set; }
        public IWebElement SearchField { get; set; }
        public IWebElement SetYes { get; set; }


        public void CarRegField(string carReg)
        {
            throw new NotImplementedException();
        }

        public void Searchreturn(string search)
        {
            

        }
        
    }


}
