using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4prt2
{
    class AirlineCompany
    {


        private SortedList<double ,Flight> flights = new SortedList<double, Flight>();

        private string AirlineName { get; }

        public AirlineCompany(string airlineName)
        {
            AirlineName = airlineName;
        }

        public Flight this[double Price] //use price as the key value so the list is sorted by price
        {
            get { return flights[Price]; }  
            set { flights.Add(Price, value); } //adds flight to the list. price is key
        }

        public void AddFlight(Flight flight)
        {
            flights.Add(flight.Price, flight); //method add flight so the objects can be transferred from main
        }


        public Flight FindFlight(int flightId)
        {
            foreach(var flight in flights)
            {
                //finds if the value of this fligts id is the same than the searched one
                if (flight.Value.Id == flightId) 
                {
                    return flight.Value;
                }
            }
            return null;
        }

        //gets the first object of the list
        public Flight GetCheapestFlight()
        {
            return flights.Values[0];
        }

        //gets the size of the list and returns the last object but list starts at 0 so - 1 ta the end 
        public Flight GetMostExpensiveFlight()
        {
            return flights.Values[flights.Count() - 1];
        }

        public void DisplayFlights()
        {
            foreach (var flight in flights.Values)
            {
                Console.WriteLine($"Flight ID: {flight.Id}, Origin: {flight.Origin}, Destination: {flight.Destination}, Date: {flight.Date}, Price: {flight.Price}£");
            }
        }
    }
}