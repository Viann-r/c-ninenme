using System;
using System.Collections.Generic;
using System.Text;

namespace _2
{
    internal class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        private int _year;
        public int Year
        {
            get
            { return _year; }
            set
            {
                if (value < 1885) { Console.WriteLine("invalid year"); }
                else { _year = value; }
            }
        }
        public string Engine { get; set; }
        public string Color { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Engine: {Engine}");
            Console.WriteLine($"Color: {Color}");
        }

    }
}
