using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    public class Drink:Item
    {
        public int Volume { get; private set; }
        public Drink(string name, double price, int volume):base(name,price)
        {
            Volume = volume;
        }
        public override string ToString()
        {
            return String.Format("Name: {0}; Price: {1}; Volume: {2}", Name, Price, Volume);
        }
    }
}
