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
    public class Guru99Steps
    {
        public IWebDriver driver = new ChromeDriver();
        Guru99Page guruPg;
        [Given(@"I guru demo site")]
        public void GivenIGuruDemoSite()
        {
            driver.Url = "http://demo.guru99.com/V4/";
            guruPg = new Guru99Page(driver);
        }
        
        [When(@"I enter credentials as '(.*)' & '(.*)'")]
        public void WhenIEnterCredentialsAs(string p0, string p1)
        {
            guruPg.UserName.SendKeys(p0);
            guruPg.Password.SendKeys(p1);
            guruPg.LoginButton.Click();
        }
        
        [Then(@"I should be logged in successfully")]
        public void ThenIShouldBeLoggedInSuccessfully()
        {
            if (driver.FindElement(By.ClassName("barone")).Displayed)
            {
                driver.Close();
            }
        }
    }
}
