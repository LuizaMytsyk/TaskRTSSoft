using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace TaskRTSSoft.Steps
{
    [Binding]
    class HeaderFluentNavigationSteps : BaseSteps
    {
        [Then(@"Header panel is displayed")]
        public void ThenHeaderPanelIsDisplayed()
        {
            Assert.IsTrue(pages.HeaderPanel.IsHeaderPanelDisplayed(), "Header navigation panel wasn't displayed");
        }
               
        [Then(@"I should see IntegritySummary tab opened")]
        public void ThenIShouldSeeIntegritySummaryTabOpened()
        {
            pages.MainPage.IsIntegritySummaryTabOpened();
        }

        [When(@"I click on Home button")]
        public void WhenIClickOnHomeButton()
        {
            pages.HeaderPanel.ClickHomeButton();
        }

        [When(@"I click on Header logo")]
        public void WhenIClickOnHeaderLogo()
        {
            pages.HeaderPanel.ClickHeaderLogo();
        }


    }
}

