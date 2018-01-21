using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    public class Food:Item
    {
        public int Weight { get; private set; }
        public Food(string name, double price, int weight):base(name,price)
        {
            Weight = weight;
        }
        public override string ToString()
        {
            return String.Format("Name: {0}; Price: {1:f2}; Weight: {2}", Name, Price, Weight);
        }
    }
}
