using System;
using TechTalk.SpecFlow;

namespace toolsqa.......Jan2019.Jan2019.StepD
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"I have Launch a new Firefox browser\.")]
        public void GivenIHaveLaunchANewFirefoxBrowser_()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I Open http://demoqa\.com/frames-and-windows/")]
        public void WhenIOpenHttpDemoqa_ComFrames_And_Windows()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I Use statement to click on a New Window button")]
        public void WhenIUseStatementToClickOnANewWindowButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I sh Close the browser")]
        public void ThenIShCloseTheBrowser()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
