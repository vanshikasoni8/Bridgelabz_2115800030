using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _18feb_generics
{
    abstract class Warehouse
    {
        public string name { get; set; }
        public double price { get; set; }

        protected Warehouse(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public abstract void Display();

    }

    class electonics : Warehouse
    {
        public string Brand { get; set; }
        public electonics(string name, string brand, double price):base(name, price)
        {
            brand = brand;
        }

        public override void Display()
        {
            Console.WriteLine($"Electonice : {name},Brand : {Brand} , Price: ${price}");
        }
    }

    class grocery : Warehouse
    {
        public DateTime expiry { get; set; }
        public grocery (string name, string category, double price): base(name, price)
        {
            expiry = expiry;

        }
        public override void Display()
        {
            Console.WriteLine($"Grocery: {name}, Price: ${price}, Expiry Date: {expiry.ToShortDateString()}");
        }
    }

    class furniture : Warehouse
    {
        public string material { get; set; }
        public furniture (string name, double price , string material ): base(name, price)
        {
            material = material;

        }
        public override void Display()
        {
            Console.WriteLine($"Furniture: {name}, Material: {material}, Price: ${price}");
        }
    }

    class storage <T> where T : Warehouse
    {
        public List<T> list { get; set; }

        public void additem(T item)
        {
            list.Add(item);
        }

        public void display()
        {
            foreach (var item in list)
            {
                item.Display();
            }
        }
    }
    class Program
    {
        static void Main()
        {
            // Creating storage for different item categories
            storage<electonics> electronicsStorage = new storage<electonics>();
            electronicsStorage.add(new electonics("Laptop", 1200, "Dell"));
            electronicsStorage.AddItem(new electonics("Smartphone", 800, "Samsung"));

            storage<Groceries> groceriesStorage = new Storage<Groceries>();
            groceriesStorage.AddItem(new Groceries("Milk", 2.5, DateTime.Now.AddDays(10)));
            groceriesStorage.AddItem(new Groceries("Bread", 1.5, DateTime.Now.AddDays(3)));

            storage<Furniture> furnitureStorage = new storage<Furniture>();
            furnitureStorage.AddItem(new Furniture("Chair", 50, "Wood"));
            furnitureStorage.AddItem(new Furniture("Table", 100, "Metal"));

            // Display all stored items
            Console.WriteLine("\nElectronics in Storage:");
            electronicsStorage.display();

            Console.WriteLine("\nGroceries in Storage:");
            groceriesStorage.DisplayAllItems();

            Console.WriteLine("\nFurniture in Storage:");
            furnitureStorage.DisplayAllItems();
        }
    }

}
