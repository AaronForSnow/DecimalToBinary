using System;
using TechTalk.SpecFlow;
using DecimalToBinary;

namespace DecimalToBinarySpec.StepDefinitions
{
    [Binding]
    public class Feature1StepDefinitions
    {
        private ScenarioContext _sc;
        public Feature1StepDefinitions(ScenarioContext scenarioContext)
        {
            _sc = scenarioContext;
        }

        [Given(@"The First Number Is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
            //throw new PendingStepException();
            _sc.Add("ToBinary", new DecToBinary());
            _sc.Add("ToConvert", p0);
        }

        [When(@"It Is Converted to Binary")]
        public void WhenItIsConvertedToBinary()
        {
            //throw new PendingStepException();
            var converter = _sc.Get<DecToBinary>("ToBinary");
            _sc.Add("answer", converter.Convert(_sc.Get<int>("ToConvert")));
        }

        [Then(@"the number has become (.*)")]
        public void ThenTheNumberHasBecome(int p0)
        {
            //throw new PendingStepException();
            _sc.Get<int>("answer").Should().Be(p0);
        }
    }
}
