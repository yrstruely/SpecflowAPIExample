using TechTalk.SpecFlow;
using NUnit.Framework;
using RestSharp;
using Newtonsoft.Json;
using SpecflowExample.DataModels;
using SpecflowExample.Clients;
using System.Collections.Generic;

namespace SpecflowExample.StepDefinitions
{
    [Binding]
    public class CircuitsApiSteps
    {
        private F1CircuitsClient client;
        private F1 f1;
        private List<Circuit> circuits;

        [Given(@"I want to know the number of Formula One races in (.*)")]
        public void GivenIWantToKnowTheNumberOfFormulaOneRacesIn(int season)
        {
            client = new F1CircuitsClient(new InMemoryCache(), new JsonSerializer(), new ErrorLogger());
            f1 = client.GetF1BySeason(season);
        }
        
        [When(@"I retrieve the circuit list for that season")]
        public void WhenIRetrieveTheCircuitListForThatSeason()
        {
            circuits = f1.MRData.CircuitTable.Circuits;
        }
        
        [Then(@"there should be (.*) circuits in the list returned")]
        public void ThenThereShouldBeCircuitsInTheListReturned(int expectedCircuits)
        {
            var actualCircuits = circuits.Count;

            Assert.AreEqual(expectedCircuits, actualCircuits);
        }
    }
}
