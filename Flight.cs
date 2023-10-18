﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4prt2
{
    class Flight
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
       
    }
}