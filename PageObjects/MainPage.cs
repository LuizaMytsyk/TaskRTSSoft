using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
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
    public class MainPage : BasePage
    {
        public MainPage(DriverFacade driverFacade) : base(driverFacade)
        {
        }


        [FindsBy(How = How.Id, Using = "PageMainHeaderFluent_navigation")]
        protected IWebElement HeaderNavigation { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='tabHeader']")]
        protected IWebElement TabHeader { get; set; }

        [FindsBy(How = How.Id, Using = "UpdatePanelTreeView")]
        protected IWebElement PanelTreeView { get; set; }

        [FindsBy(How = How.Id, Using = "txtWellSearch")]
        protected IWebElement SearchWellField { get; set; }

        [FindsBy(How = How.Id, Using = "ASPxPageControlOverview_AT0")]
        protected IWebElement IntegritySummaryTabOpened { get; set; }

        [FindsBy(How = How.XPath, Using = "ASPxPageControlOverview_AT0")]
        protected IWebElement wellHeading { get; set; }



        public bool IsWellNameDisplayedOnOverview(string wellName)
        {
            return IsTextCorrect(wellHeading, wellName);
        }


        public void InputTextInSearchWellField(string wellName)
        {
            InputText(SearchWellField, wellName);
        }


        public bool IsSearchDropListDisplayed()
        {
            return IsElementPresent(SearchWellField);
        }


        public bool IsIntegritySummaryTabOpened()
        {
            return IsElementPresent(IntegritySummaryTabOpened);
        }


        public bool IsPageOpened()
        {
            return IsElementPresent(HeaderNavigation)
                & IsElementPresent(PanelTreeView)
                & IsTextCorrect(TabHeader, "Distribution");
        }




    }
}

