using MultipleInheritance.Entities;
using System;


namespace MultipleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer() { SerialNumber = 1080 };
            p.ProcessDoc("MyLetter");
            p.Print("MyLetter");

            Console.WriteLine();

            Scanner s = new Scanner() { SerialNumber = 1030 };
            s.ProcessDoc("My email");
            Console.WriteLine(s.Scan());

            Console.WriteLine();

            ComboDevice cb = new ComboDevice { SerialNumber = 1015 };
            cb.ProcessDoc("My dissertion");
            cb.Print("My dissertion");
            Console.WriteLine(cb.Scan());

            Console.ReadKey();            

        }
    }
}
