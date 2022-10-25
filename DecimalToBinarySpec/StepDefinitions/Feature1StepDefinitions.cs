using System;
using TechTalk.SpecFlow;

namespace DecimalToBinarySpec.StepDefinitions
{
    [Binding]
    public class Feature1StepDefinitions
    {
        private ScenarioContext _scenarioContext;
        public Feature1StepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"The First Number Is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
            throw new PendingStepException();
        }

        [When(@"It Is Converted to Binary")]
        public void WhenItIsConvertedToBinary()
        {
            throw new PendingStepException();
        }

        [Then(@"the number has become (.*)")]
        public void ThenTheNumberHasBecome(int p0)
        {
            throw new PendingStepException();
        }
    }
}
