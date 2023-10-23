using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace assignment4prt2
{
    class Flight : IComparable<Flight>
    {
        public int Id { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string Date { get; set; }
        public double Price { get; set; }

        public Flight(int id, string origin, string destination, string date, double price)
        {
            Id = id;
            Origin = origin;
            Destination = destination;
            Date = date;
            Price = price;
        }

        public Flight() { } 

        public override string ToString()
        {
            return $"Flight ID: {this.Id}, Origin: {this.Origin}, Destination: {this.Destination}, Date: {this.Date}, Price: {this.Price}£";
        }

        public int CompareTo(Flight obj)
        {
            if (obj == null)
                return 0;
            if (obj is Flight)
            {
                Flight temp = (Flight)obj;
                if (this.Price > temp.Price)
                    return 1;
                else if (this.Price < temp.Price)
                    return -1;
                return 0;
            }
            return 0;
        }



    }
}