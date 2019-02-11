using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Jan2019.Page
{
    public class Guru99Page
    {
        IWebDriver driver;

        [FindsBy(How = How.Name, Using = "uid")]
        public IWebElement UserName { get; set; }

        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Name, Using = "btnLogin")]
        public IWebElement LoginButton { get; set; }

        public Guru99Page(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

      

    }
}
