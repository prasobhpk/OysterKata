namespace OysterKata
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Security.Policy;

    public class Station
    {
        readonly string _name;

        public StationZone Zone;

        Dictionary<string, StationZone> _stationZones = new Dictionary<string, StationZone>
        {
            { "Asterisk", StationZone.A}, 
            { "Aldgate", StationZone.A}, 
            { "Barbican", StationZone.B}, 
            { "Balham", StationZone.B}, 
        };

        public Station(string name)
        {
            _name = name;
            Zone = _stationZones[name];
        }
    }

    public enum StationZone
    {
        A,
        B
    }
}