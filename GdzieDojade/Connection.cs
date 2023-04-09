using System;
using System.Collections.Generic;

namespace GdzieDojade
{
    internal class Connection
    {
        public Connection(int id, int source, int destination, int distance, int price, DateTime departureTime, DateTime arrivalTime, int transportType)
        {
            Id = id;
            Source = source;
            Destination = destination;
            Distance = distance;
            Price = price;
            DepartureTime = departureTime;
            ArrivalTime = arrivalTime;
            TransportType = transportType;
        }

        // Source and destination are city id's
        public int Id { get; }
        public int Source { get; }
        public int Destination { get; }

        // Distance in km
        public int Distance { get; }

        // Price in PLN
        public int Price { get; }

        // Time in minutes after midnight
        public DateTime DepartureTime { get; }

        // Lenght of time in minutes
        public DateTime ArrivalTime { get; }

        // Transport type id
        // 0 - bus, 1 - plane, 2 - train
        public int TransportType { get; }

        // overload of ToString() using default variables
        public override string ToString()
        {
            return $"Id: {Id}\t {Source} -> {Destination}\t {Distance} km\t {Price} PLN\t Dep: {DepartureTime}\t Arr: {ArrivalTime}\t Type: {TransportType}";
        }

        // overload of ToString() using two variables, dict of cities and dict of transportTypes
        public string ToString(Dictionary<int, string> cityNames, Dictionary<int, string> transportTypes)
        {
            string sourceCity = cityNames.ContainsKey(Source) ? cityNames[Source] : Source.ToString();
            string destinationCity = cityNames.ContainsKey(Destination) ? cityNames[Destination] : Destination.ToString();
            string transportType = transportTypes.ContainsKey(TransportType) ? transportTypes[TransportType] : TransportType.ToString();

            return $"{Id}\t{sourceCity} -> {destinationCity}\t{Distance}Km\t\t{Price}PLN\t{DepartureTime}\t{ArrivalTime}\t{transportType}";
        }
    }
}
