namespace OysterKata
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization.Formatters;

    public class ClamCard
    {
        const decimal ZoneADayCap = 7m;

        const decimal ZoneBDayCap = 8m;

        readonly Traveller _traveller;

        public IList<Journey> Journeys;

        public ClamCard(Traveller traveller)
        {
            _traveller = traveller;
            Journeys = new List<Journey>();
        }

        public decimal TotalCharge
        {
            get
            {
                decimal totalCost = 0m;
                // are all journeys on the same day
                if (Journeys.Select(x => x.JourneyDate.Date).Distinct().Count() == 1)
                {
                    totalCost = Journeys.Sum(x => x.Cost);

                    if (totalCost > ZoneADayCap && Journeys.All(x => x.BothinZoneA))
                        return ZoneADayCap;

                    if (totalCost > ZoneBDayCap)
                        return ZoneBDayCap;

                }
                return totalCost;
 
            }
        }

        public void AddJourney(Journey journey)
        {
            Journeys.Add(journey);
        }
    }
}