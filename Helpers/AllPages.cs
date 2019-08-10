using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskRTSSoft.Pages;

namespace TaskRTSSoft.Helpers
{
    public class AllPages
    {

        public DriverFacade _driverFacade;
        private MainPage mainPage;
        private LoginPage loginPage;
        private HeaderPanel headerPanel;


        public AllPages(DriverFacade driverFacade)
        {
            _driverFacade = driverFacade;
        }

        public MainPage MainPage
        {
            get
            {
                if (mainPage == null)
                {
                    mainPage = new MainPage(_driverFacade);
                }
                return mainPage;
            }

        }


        public LoginPage LoginPage
        {
            get
            {
                if (loginPage == null)
                {
                    loginPage = new LoginPage(_driverFacade);
                }
                return loginPage;
            }

        }


        public HeaderPanel HeaderPanel
        {
            get
            {
                if (headerPanel == null)
                {
                    headerPanel = new HeaderPanel(_driverFacade);
                }
                return headerPanel;
            }

        }
    }
}

