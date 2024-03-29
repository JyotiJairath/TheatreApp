﻿using System;
namespace TheatreApp
{
    Public  class Show
    {
        public double Price { get; }
        public Day Day { get; }
        public Movie Movie { get; }
        public Time Time { get; }
        public Show(Movie movie, Day day, double price, Time time)
        {
            Movie = movie;
            Day = day;
            Price = price;
            Time = time;
        }
        public override string ToString()
        {

            return $" The {Movie}start at {Day} {Time} and cost {Price}";
        }
    }
}
