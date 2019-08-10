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

    public class SearchWellByNameSteps : BaseSteps
    {

        [When(@"I input well name '(.*)' in Search field")]
        public void WhenIInputWellNameInSearchField(string wellName)
        {
            pages.MainPage.InputTextInSearchWellField(wellName);
        }
      

        [Then(@"'(.*)' should be displayed as a link")]
        public void ThenWellNameShouldBeDisplayedOnOverview(string wellName)
        {
            Assert.IsTrue(pages.MainPage.IsWellNameDisplayedOnOverview(wellName), "Well name wasn't displayed on Overview");

        }

        [Then(@"I should see droplist with search suggestions displayed")]
        public void ThenIShouldSeeDroplistWithSearchSuggestionsDisplayed()
        {
            Assert.IsTrue(pages.MainPage.IsSearchDropListDisplayed(), "Search DropList wasn't displayed");
        }



    }
}
