using BoDi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowExample.Hooks
{
    [Binding]
    public sealed class BeforeHook
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        private readonly IObjectContainer objectContainer;

        public BeforeHook(IObjectContainer objectContainer)
        {
            this.objectContainer = objectContainer;
        }
        
        [BeforeScenario("A_API")]
        public void BeforeScenarioA()
        {
            SetAPI("A");
        }

        [BeforeScenario("B_API")]
        public void BeforeScenarioB()
        {
            SetAPI("B");
        }

        private void SetAPI(string api)
        {
            IRequest request = null;
            IResponse response = null;
            switch (api)
            {
                case "A":
                    request = new ARequest();
                    response = new AResponse();
                    break;
                case "B":
                    request = new BRequest();
                    response = new BResponse();
                    break;

            }
            objectContainer.RegisterInstanceAs<IRequest>(request);
            objectContainer.RegisterInstanceAs<IResponse>(response);
        }

        [AfterScenario("A_API")]
        public void AfterScenarioA()
        {
            TearDown("A");
        }

        [AfterScenario("B_API")]
        public void AfterScenarioB()
        {
            TearDown("B");
        }

        public void TearDown(string api)
        {
            switch (api)
            {
                case "A":
                    objectContainer.Resolve<ARequest>("request").Dispose();
                    objectContainer.Resolve<AResponse>("response").Dispose();
                    break;
                case "B":
                    objectContainer.Resolve<BRequest>("request").Dispose();
                    objectContainer.Resolve<BResponse>("response").Dispose();
                    break;

            }
        }
    }
}
