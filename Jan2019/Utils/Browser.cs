using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Jan2019.Utils
{
    class Browser
    {
        private static IWebDriver driver;
        public static void InitializeBrowser()
        {
            driver = new ChromeDriver();
        }

        public static void LoadApp(String url)
        {
            driver.Url = url;
        }

        public static IWebDriver GetDriver()
        {
            return driver;
        }
    }
}
