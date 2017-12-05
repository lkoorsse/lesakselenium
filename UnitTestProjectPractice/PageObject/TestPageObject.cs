using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace UnitTestProjectPractice.PageObject
{
    public interface ITestPageObject
    {
      //  void getCarRegField(carReg);

    }
    public class WaitPageObject
    {
        private static IWebDriver webDriver;


        public static void WaitForElementLoad(By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(timeoutInSeconds));
                wait.Until(ExpectedConditions.ElementIsVisible(by));
            }
        }
    }
}

