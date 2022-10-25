using System;
using TechTalk.SpecFlow;
using DecimalToBinary;

//Aaron Allen For Class Oct 2022 Tests
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
        public void ThenTheNumberHasBecome(string p0)
        {
            //throw new PendingStepException();
            _sc.Get<string>("answer").Should().Be(p0);
        }
    }
}
