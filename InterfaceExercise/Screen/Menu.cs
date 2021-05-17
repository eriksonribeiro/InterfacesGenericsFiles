using System;
using InterfaceExercise.Entities;
using InterfaceExercise.Services;
using System.Globalization;

namespace InterfaceExercise.Screen
{
    static class Menu
    {
       public static void CallMenu()
        {
            Console.WriteLine("Enter contract data:");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy",CultureInfo.InvariantCulture);
            Console.Write("Contract Value: ");
            double totalValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int installment = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, totalValue);
            ContractService contractService = new ContractService(new PayPalService());
            contractService.ProcessContract(contract, installment);

            Console.WriteLine("Installments:");
            foreach (Installment month in contract.Installments)
            {
                Console.WriteLine(month); 
            }

            Console.ReadKey();
        }
    }
}
