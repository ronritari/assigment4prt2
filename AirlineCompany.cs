using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4prt2
{
    class AirlineCompany
    {


        private SortedList<Flight, double> flights = new SortedList<Flight, double>();

        private readonly string airlineName;

        public AirlineCompany(string AirlineName)
        {
            airlineName = AirlineName;
        }

        public Flight this[int id] //use price as the key value so the list is sorted by price
        {

            get { 
                foreach (Flight flight in flights.Keys)
                {
                    return flight.Id == id ? flight: new Flight();
                }
                return new Flight();
                }  
            set { flights.Add(value, value.Price); } //adds flight to the list. price is key
        }



        public Flight FindFlight(int flightId)
        {
            foreach(var flight in flights)
            {
                //finds if the value of this fligts id is the same than the searched one
                if (flight.Key.Id == flightId) 
                {
                    return flight.Key;
                }
            }
            return null;
        }

        //gets the first object of the list
        public Flight GetCheapestFlight()
        {
            return flights.Keys[0];
        }

        //gets the size of the list and returns the last object but list starts at 0 so - 1 ta the end 
        public Flight GetMostExpensiveFlight()
        {
            return flights.Keys[flights.Count() - 1];
        }

        public void DisplayFlights()
        {
            foreach (var flight in flights.Keys)
            {
                Console.WriteLine(flight.ToString());
            }
        }
    }
}