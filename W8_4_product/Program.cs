using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W8_4_product
{

    class Product
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Manufacturer { get; set; }
        public double Price { get; set; }
        public string OtherDescriptions { get; set; }

        public Product(string productCode, string productName, string manufacturer, double price, string otherDescriptions)
        {
            ProductCode = productCode;
            ProductName = productName;
            Manufacturer = manufacturer;
            Price = price;
            OtherDescriptions = otherDescriptions;
        }

        public override string ToString()
        {
            return $"Product Code: {ProductCode}, Name: {ProductName}, Manufacturer: {Manufacturer}, Price: {Price}, Other Descriptions: {OtherDescriptions}";
        }
    }

    class Program
    {
        static List<Product> products = new List<Product>();

        static void Main(string[] args)
        {
            LoadProducts();

            while (true)
            {
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Display Products");
                Console.WriteLine("3. Search Product");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddProduct();
                        break;
                    case "2":
                        DisplayProducts();
                        break;
                    case "3":
                        SearchProduct();
                        break;
                    case "4":
                        SaveProducts();
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter again.");
                        break;
                }
            }
        }

        static void AddProduct()
        {
            Console.WriteLine("Enter Product Code:");
            string productCode = Console.ReadLine();
            Console.WriteLine("Enter Product Name:");
            string productName = Console.ReadLine();
            Console.WriteLine("Enter Manufacturer:");
            string manufacturer = Console.ReadLine();
            Console.WriteLine("Enter Price:");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Other Descriptions:");
            string otherDescriptions = Console.ReadLine();

            Product newProduct = new Product(productCode, productName, manufacturer, price, otherDescriptions);
            products.Add(newProduct);
            Console.WriteLine("Product added successfully!");
        }

        static void DisplayProducts()
        {
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }

        static void SearchProduct()
        {
            Console.WriteLine("Enter Product Code to search:");
            string searchCode = Console.ReadLine();
            var foundProduct = products.Find(product => product.ProductCode == searchCode);
            if (foundProduct != null)
            {
                Console.WriteLine("Product Found:");
                Console.WriteLine(foundProduct);
            }
            else
            {
                Console.WriteLine("Product not found!");
            }
        }

        static void LoadProducts()
        {
            if (File.Exists("products.dat"))
            {
                using (BinaryReader reader = new BinaryReader(File.Open("products.csv", FileMode.Open)))
                {
                    while (reader.PeekChar() > -1)
                    {
                        string productCode = reader.ReadString();
                        string productName = reader.ReadString();
                        string manufacturer = reader.ReadString();
                        double price = reader.ReadDouble();
                        string otherDescriptions = reader.ReadString();
                        products.Add(new Product(productCode, productName, manufacturer, price, otherDescriptions));
                    }
                }
            }
        }

        static void SaveProducts()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open("products.csv", FileMode.Create)))
            {
                foreach (var product in products)
                {
                    writer.Write(product.ProductCode);
                    writer.Write(product.ProductName);
                    writer.Write(product.Manufacturer);
                    writer.Write(product.Price);
                    writer.Write(product.OtherDescriptions);
                }
            }
        }

    }
}
