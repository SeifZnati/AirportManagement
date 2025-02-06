using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;

namespace AM.ApplicationCore.Services
{
    public class FlightMethods : IFlightMethods
    {
        public List<Flight> Flights { get; set; } = new List<Flight> { };

        //Avec For
        //public IList<DateTime> GetFlightDates(string destination)
        //{
        //    IList<DateTime> dates = new List<DateTime> { };
        //    for (int i = 0; i < Flights.Count; i++)
        //    {
        //        if (Flights[i].Destination.Equals(destination))
        //        {
        //            dates.Add(Flights[i].FlightDate);
        //        }
        //    }
        //    return dates;
        //}

        //Avec ForEach
        public IList<DateTime> GetFlightDates(string destination)
        {
            IList<DateTime> dates = new List<DateTime> { };
            foreach (var flight in Flights)
            {
                {
                    if (flight.Destination.Equals(destination))
                    {
                        dates.Add(flight.FlightDate);
                    }
                }
            }
            return dates;
        }

        public void GetFlights(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "Destination":
                    foreach (var flight in Flights)
                    {
                        if (flight.Destination.Equals(filterValue))
                        {
                            System.Console.WriteLine(flight.ToString());
                        }
                    }
                    break;
            }
        }
    }
}
