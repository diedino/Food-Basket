using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop;

namespace ConsoleApp6
{
    class Program
    {
        static readonly string[] food = new string[] { "Apple", "Orange", "Potato", "Burger" };
        static readonly string[] drink = new string[] { "Coca-Cola", "Fanta", "Sprite", "Mountine Dew" };
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    int maxJ = 0, maxI = 0;
                    double maxPrice = 0, maxCost = 0, cost = 0;
                    Item[] arr = new Item[8];
                    Random rand = new Random(DateTime.Now.Millisecond);
                    FoodBasket[] foodBasket = new FoodBasket[rand.Next(10, 16)];
                    for (int i = 0; i < foodBasket.Length; i++)
                    {
                        for (int j = 0; j < arr.Length; j++)
                        {
                            switch (rand.Next(1, 6))
                            {
                                case 1:
                                case 2:
                                case 3:
                                    arr[j] = new Food(food[rand.Next(0, 4)], rand.Next(30, 2990)+rand.NextDouble() * 10, rand.Next(10, 101));
                                    break;
                                case 4:
                                case 5:
                                    arr[j] = new Drink(drink[rand.Next(0, 4)], rand.Next(30, 2990) + rand.NextDouble() * 10, rand.Next(10, 101));
                                    break;
                            }
                        }
                        foodBasket[i] = new FoodBasket(8, arr);
                    }
                    for (int i = 0; i < foodBasket.Length; i++)
                    {
                        for (int j = 0; j < arr.Length; j++)
                        {
                            Console.WriteLine(foodBasket[i][j].ToString());
                        }
                        Console.WriteLine("*********************");
                    }
                    for (int i = 0; i < foodBasket.Length; i++)
                    {
                        for (int j = 0; j < arr.Length; j++)
                        {
                            if (foodBasket[i][j].Price > maxPrice)
                            {
                                maxPrice = foodBasket[i][j].Price;
                                maxJ = j;
                            }
                        }
                        Console.Write("В {0} корзине максимальная цена: {1:f2}", i + 1, foodBasket[i][maxJ].ToString());
                        Console.WriteLine();
                    }
                    for (int i = 0; i < foodBasket.Length; i++)
                    {
                        if (foodBasket[i].BasketCost() > maxCost)
                        {
                            maxCost = foodBasket[i].BasketCost();
                            maxI = i;
                        }
                    }
                    Console.Write("Самая дорогая корзина: {0:f2}", maxI + 1);
                    Console.WriteLine();
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
