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
    public class HeaderPanel : BasePage
    {
        public HeaderPanel(DriverFacade driverFacade) : base(driverFacade)
        {
        }

        [FindsBy(How = How.Id, Using = "PageMainHeaderFluent_applicationLogo")]
        protected IWebElement HeaderLogo { get; set; }

        [FindsBy(How = How.Id, Using = "PageMainHeaderFluent_navigation")]
        protected IWebElement HeaderNavigation { get; set; }

        [FindsBy(How = How.Id, Using = "PageMainHeaderFluent_Home")]
        protected IWebElement HomeButton { get; set; }

        public void ClickHomeButton()
        {
            HomeButton.Click();
        }

        public void ClickHeaderLogo()
        {
            throw new NotImplementedException();
        }

        public bool IsHeaderPanelDisplayed()
        {
            return IsElementPresent(HeaderNavigation);
        }
    }
}
