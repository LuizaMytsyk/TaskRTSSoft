using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace TaskRTSSoft.Steps
{
    [Binding]

    class LoginSteps : BaseSteps
    {

        [Given(@"I Navigate to the Login page")]
        public void GivenINavigateToTheLoginPage()
        {
            driverFacade.NavigateToURL("http://wimsdemo.exprosoft.com");
        }

        [When(@"I Login with Username '(.*)' and Password '(.*)' on the LoginPage")]
        public void WhenILoginWithUsernameAndPasswordOnTheLoginPage(string username, string password)
        {
            pages.LoginPage.LoginAs(username, password);
        }

        [Then(@"the MainPage should be opened")]
        public void ThenTheMainPageShouldBeOpened()
        {
            Assert.IsTrue(pages.MainPage.IsPageOpened());
        }

        [When(@"I Unsucessfully Login with Username '(.*)' and Password '(.*)' on the Login Page")]
        public void WhenIUnsucessfullyLoginWithUsernameRDAgXOnTheLoginPage(string username, string password)
        {
            pages.LoginPage.LoginUnsuccessfullyAs(username, password);
        }

        [Then(@"I Should See Error Message '(.*)' on the Login Page")]
        public void ThenIShouldSeeErrorMessageOnTheLoginPage(string message)
        {
            pages.LoginPage.GetErrorMessage();
        }


    }
}
