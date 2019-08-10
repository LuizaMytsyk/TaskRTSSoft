using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskRTSSoft.Helpers
{
    public class DriverFacade
    {
        public IWebDriver driver { get; }

        public DriverFacade()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        }

        public void NavigateToURL(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void Quit()
        {
            driver.Quit();
        }

    }
}
