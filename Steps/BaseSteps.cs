using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskRTSSoft.Helpers;
using TechTalk.SpecFlow;

namespace TaskRTSSoft.Steps
{
    public class BaseSteps
    {
        public AllPages pages;
        public DriverFacade driverFacade;


        [BeforeScenario]

        public void BeforeScenario()
        {

            driverFacade = new DriverFacade();
            pages = new AllPages(driverFacade);

        }

        [AfterScenario]

        public void AfterScenario()
        {

            if (driverFacade != null)
                driverFacade.Quit();

        }


    }
}
