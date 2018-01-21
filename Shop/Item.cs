using System;

namespace Shop
{
    public abstract class Item
    {
        string name;
        double price;
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (value <= 0) throw new ArgumentException("Цена не может быть <=0");
                else price = value;
            }
        }
        public Item(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
