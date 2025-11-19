using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_25_Lists_and_collections_in_c_sharp
{
    internal class Program
    {
        class Inventory
        {
            private List<string> items = new List<string>();

            private Dictionary<string, (double price, int stock)> ItemDetails =
                new Dictionary<string, (double price, int stock)>();

            //Adds item
            public void AddItem(string ProductName, double price, int stock)
            {
                if(!items.Contains(ProductName))
                {
                    items.Add(ProductName);
                    ItemDetails[ProductName] = (price, stock);
                }
                else
                {
                    Console.WriteLine($"{ProductName} allredy exist");
                }
            }

                //Removes item
                public void removeItem(string ProductName)
            {
                if(!items.Contains(ProductName))
                {
                    items.Remove(ProductName);
                }
                else
                {
                    Console.WriteLine($"{ProductName} does not excist");
                }
            }

            //Updates item
            public void UpdateStock(string  ProductName, int updatedStock)
            {
                if(items.Contains(ProductName))
                {
                    double price = ItemDetails[ProductName].price;
                    ItemDetails[ProductName] = (price, updatedStock);
                }
                else
                {
                    Console.WriteLine($"{ProductName} cannot be found");
                }
            }

            //Print all items
            public void PrintAllItems()
            {
                if(items.Count == 0)
                {
                    Console.WriteLine("The inventory is empty");
                    return;
                }
                foreach(string item in items)
                {
                    var (price, stock) = ItemDetails[item];
                    Console.WriteLine($"{item}: Price: ${price}, Stock: {stock}");
                }
            }


            //Prints the most expensive item
            public void mostExpensive()
            {
                double TheHighestPrice = 0;
                string TheMostExpensive = null;

                if (items.Count == 0)
                {
                    return;
                }
                foreach(string item in items)
                {
                    double price = ItemDetails[item].price;
                    if (price > TheHighestPrice)
                    {
                        TheHighestPrice = price;
                        TheMostExpensive = item;
                    }
                }
                Console.WriteLine("The Most expensive item: " + TheMostExpensive + " The price is: " + TheHighestPrice);
            }


            //Prints the total inventory
            public void TotalInventory()
            {
                double total = 0;

                foreach (string item in items)
                {
                    var (price, stock) = ItemDetails[item];
                    total += price * stock;
                }
                Console.WriteLine($"This is the total inventory: ${total:F2}");
            }


        }
        static void Main(string[] args)
        {
            //Here i call for my methods in the class
            Inventory inventory = new Inventory();

            inventory.AddItem("Laptop", 1200.50, 7);
            inventory.AddItem("SmartPhone", 799.99, 12);
            inventory.AddItem("Tablet", 399.99, 15);

            inventory.PrintAllItems();


            inventory.UpdateStock("Laptop", 5);

            inventory.removeItem("Tablet");

            inventory.mostExpensive();

            inventory.PrintAllItems();

        }
    }
}
