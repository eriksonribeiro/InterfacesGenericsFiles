using System;
using System.Globalization;
using RentalServiceWithoutInterface.Entities;
using RentalServiceWithoutInterface.Services;

namespace RentalServiceWithoutInterface.Screen
{
    static class Menu
    {
        public static void ShowMenu()
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car Model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/ yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/ yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Enter price per Hour: ");
            double hour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Enter price per Day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalService = new RentalService(hour, day);

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE");
            Console.WriteLine(carRental.Invoice);

        }
    }
}
