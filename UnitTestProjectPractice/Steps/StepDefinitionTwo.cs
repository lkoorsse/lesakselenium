using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitTestProjectPractice.WrapperFactory;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using StructureMap;
using OpenQA.Selenium.Support.PageObjects;
using TechTalk.SpecFlow;
using UnitTestProjectPractice.PageObject;


namespace UnitTestProjectPractice.Steps
{
    [Binding]
    public class StepDefinitionTwo : Page
    {
        private readonly ITestPageObject _testPageObject;

        public StepDefinitionTwo(IWebDriver driver) : base(driver)
        {
          //  _testPageObject = PageFactory.InitElements<Page>()

        }
        

            [Given(@"I am at '(.*)' website")]

            public void GivenIAmAtWebsite(string url)
            {
                _testPageObject.Url.SendKeys(url);
            }

            [Given(@"I browse to website '(.*)'")]

            public void GivenIBrowseToWebsite(string search)
            {
                _testPageObject.SearchField.SendKeys(search);
            }

            [Given(@"I select get quote button")]

            public void GivenISelectGetQuoteButton()
            {
                _testPageObject.QuoteButton.Click();
            }

            [Given(@"I insert '(.*)' into car reg field")]

            public void GivenIInsertIntoCarRegField(string carReg)
            {
                _testPageObject.CarRegField(carReg);
            }

            [When(@"I select find car button")]

            public void WhenISelectFindCarButton()
            {
                ScenarioContext.Current.Pending();
            }

            [Then(@"the car reg field is popolated into the reg field")]

            public void ThenTheCarRegFieldIsPopolatedIntoTheRegField()
            {
                ScenarioContext.Current.Pending();
            }

            [When(@"I complete all mandatory radio buttons to Yes")]

            public void WhenICompleteAllMandatoryRadioButtonsToYes()
            {
                _testPageObject.SetYes.Click();
            }

            [When(@"I complete purchased car month '(.*)' and year '(.*)'")]

            public void WhenICompletePurchasedCarMonthAndYear(int p0, int p1)
            {
                ScenarioContext.Current.Pending();
            }

            [When(@"I select for use of car dropdown '(.*)'")]

            public void WhenISelectForUseOfCarDropdown(string p0)
            {
                ScenarioContext.Current.Pending();
            }

            [When(@"I select '(.*)' button")]

            public void WhenISelectButton(string p0)
            {
                ScenarioContext.Current.Pending();
            }

            [When(@"select for total annual milage dropdown '(.*)'")]

            public void WhenSelectForTotalAnnualMilageDropdown(string p0)
            {
                ScenarioContext.Current.Pending();
            }

            [When(@"for first name insert '(.*)' and Surname '(.*)'")]

            public void WhenForFirstNameInsertAndSurname(string p0, string p1)
            {
                ScenarioContext.Current.Pending();
            }

            [When(@"for Date of birth Day '(.*)'(.*)'(.*)'(.*)'")]

            public void WhenForDateOfBirthDay(string p0, int p1, string p2, int p3)
            {
                ScenarioContext.Current.Pending();
            }

            [When(@"insert e-mail adress '(.*)'")]

            public void WhenInsertE_MailAdress(string p0)
            {
                ScenarioContext.Current.Pending();
            }

            [Then(@"the email adress should contain '(.*)'")]

            public void ThenTheEmailAdressShouldContain(string p0)
            {
                ScenarioContext.Current.Pending();
            }

        }
    }

