using System;
using TechTalk.SpecFlow;
using Jan2019.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using Jan2019.Utils;


namespace Jan2019.StepD
{
    [Binding]
    public class ExampleKeywordSteps
    {
        public IWebDriver driver = new ChromeDriver();
        Guru99Page guruPg;
        [Given(@"I am on guru demo site")]
        public void GivenIAmOnGuruDemoSite()
        {
            driver.Url = "http://demo.guru99.com/V4/";
            guruPg = new Guru99Page(driver);
        }
        
        [When(@"I enter (.*) and (.*)")]
        public void WhenIEnterAnd(string Username, string Password)
        {
            guruPg.UserName.SendKeys(Username);
            guruPg.Password.SendKeys(Password);
            guruPg.LoginButton.Click();
        }
        
        
        [Then(@"I should be logged in successfully\.")]
        public void ThenIShouldBeLoggedInSuccessfully_()
        {
            if (driver.FindElement(By.ClassName("barone")).Displayed)
            {
                driver.Close();
            }
        }


    }
}
