namespace OysterKata
{
    using System;

    public class Journey
    {
        public DateTime JourneyDate;

        public Journey(DateTime journeyDate)
        {
            JourneyDate = journeyDate;
        }

        public Station From { get; set; }
        
        public Station To { get; set; }

        public decimal Cost
        {
            get
            {
                return BothinZoneA ? 2.5m : 3.00m;
            }
        }

        public bool BothinZoneA
        {
            get
            {
                return From.Zone == StationZone.A && To.Zone == StationZone.A;
            }
        }



    }
}