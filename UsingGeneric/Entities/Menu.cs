using System;
using System.Collections.Generic;
using System.Globalization;

namespace UsingGeneric.Entities
{
    static class Menu
    {
        public static void ShowMenuPrintService()
        {
            PrintService printService = new PrintService();

            Console.Write("How many values: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            printService.Print();
            Console.WriteLine($"First: {printService.First()}");
        }

        public static void ShowMenuPrintServiceGeneric()
        {
            PrintServiceGeneric<int> printServiceGeneric = new PrintServiceGeneric<int>();

            Console.Write("How many values: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printServiceGeneric.AddValue(x);
            }

            printServiceGeneric.Print();
            Console.WriteLine($"First: {printServiceGeneric.First()}");
        }

        public static void ShowMenuCalculationService()
        {
            List<int> list = new List<int>();

            Console.Write("How many values: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                list.Add(x);
            }

            CalculationService calculation = new CalculationService();

            Console.WriteLine($"Max: {calculation.Max(list)}");
            Console.WriteLine($"Max: {calculation.MaxGeneric(list)}");

        }

        public static void ShowMenuCalculationServiceProducts()
        {
            List<Product> list = new List<Product>();

            Console.Write("How many values: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Put the Product Name and Price splitted by ';': ");
                string[] data = Console.ReadLine().Split(';');
                string name = data[0];
                double price = double.Parse(data[1], CultureInfo.InvariantCulture);
                list.Add(new Product(name, price));
            }

            CalculationService calculation = new CalculationService();

            Product max = calculation.MaxGeneric(list);

            Console.WriteLine($"Max: {max}");

        }
    }
}
