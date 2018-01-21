using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    public class FoodBasket
    {
        Item[] foodBasket;
        int size;
        public FoodBasket(int n, Item[] arr)
        {
            foodBasket = new Item[n];
            for (int i=0; i < n; i++)
            {
                foodBasket[i] = arr[i];
            }
        }
        public double BasketCost()
        {
            double cost=0;
            for (int i = 0; i < foodBasket.Length; i++)
            {
                cost += foodBasket[i].Price;
            }
            return cost;
        }
        public Item this[int index]
        {
            get { return foodBasket[index]; }
        }
    }
}
