namespace OysterKata.Tests
{
    using System;
    using System.Linq;

    using OysterKata;
    using Shouldly;

    using TechTalk.SpecFlow;

    [Binding]
    public class ClamCardJourneysSteps
    {
        Traveller Michael;

        ClamCard Card;

        [Given(@"Michael has a ClamCard")]
        public void GivenMichaelHasAClamCard()
        {
            Michael = new Traveller();
            Card = new ClamCard(Michael);
        }

        [Given(@"Michael travels from (.*) to (.*)")]
        public void GivenMichaelTravelsFromAsteriskToAldgate(string from, string to)
        {
            Journey journey = new Journey();
            journey.From = new Station(from);
            journey.To = new Station(to);
            Card.AddJourney(journey);
        }

        [Then(@"Michael will be charged £(.*) for all his journeys")]
        public void ThenMichaelWillBeChargedForAllHisJourneys_(Decimal amount)
        {
            Card.TotalCharge.ShouldBe(amount);
        }

        [Then(@"Michael will be charged £(.*) for his first journey")]
        public void ThenMichaelWillBeChargedForHisFirstJourney(Decimal amount)
        {
            Card.Journeys.First().Cost.ShouldBe(amount);
        }

        [Then(@"a further £(.*) for his second journey")]
        public void ThenAFurtherForHisSecondJourney(Decimal amount)
        {
            Card.Journeys.Skip(1).First().Cost.ShouldBe(amount);
        }

        [Given(@"the date is (.*)")]
        public void GivenTheDateIs(DateTime date)
        {
            ScenarioContext.Current.Pending();
        }


    }
}