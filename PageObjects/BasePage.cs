using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskRTSSoft.Helpers;

namespace TaskRTSSoft.Pages
{
    public class BasePage
    {
        protected readonly DriverFacade driverFacade;

        public BasePage(DriverFacade driverFacade)
        {
            this.driverFacade = driverFacade;
            PageFactory.InitElements(driverFacade.driver, this);
        }

        public void Click(IWebElement element)
        {
            element.Click();
        }

        public void InputText(IWebElement element, string text)
        {
            element.SendKeys(text);
        }


        public bool IsTextCorrect(IWebElement element, string expectedText)
        {
            String actualString = element.Text;
            if (actualString.Contains(expectedText))
            { return false; }
            return true;
        }

        public bool IsElementPresent(IWebElement element)
        {
            if (element == null)
            { return false; }
            return true;
        }
    }
}

