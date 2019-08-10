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
    
        public class LoginPage : BasePage
        {
            public LoginPage(DriverFacade driverFacade) : base(driverFacade)
            {
            }

            [FindsBy(How = How.Id, Using = "LoginUser_UserName")]
            protected IWebElement UsernameTxtBox { get; set; }

            [FindsBy(How = How.Id, Using = "LoginUser_Password")]
            protected IWebElement PasswordTxtBox { get; set; }

            [FindsBy(How = How.Id, Using = "LoginUser_LoginButton")]
            protected IWebElement LoginBtn { get; set; }

            [FindsBy(How = How.XPath, Using = "//span[@class='failureNotification']")]
            protected IWebElement ErrorText { get; set; }



            public MainPage LoginAs(string username, string password)
            {
                Login(username, password);
                return new MainPage(driverFacade);
            }

            public LoginPage LoginUnsuccessfullyAs(string username, string password)
            {
                Login(username, password);
                return this;
            }

            public string GetErrorMessage()
            {
                return ErrorText.Text;
            }

            private void Login(string username, string password)
            {
                UsernameTxtBox.SendKeys(username);
                PasswordTxtBox.SendKeys(password);
                Click(LoginBtn);
            }
        }
}

