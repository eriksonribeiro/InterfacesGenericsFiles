using MultipleInheritance.Interfaces;
using System;

namespace MultipleInheritance.Entities
{
    class ComboDevice : Device, IPrinter, IScanner
    {
        public void Print(string document)
        {
            Console.WriteLine($"ComboDevice Print {document}");
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine($"ComboDevice Processing {document}");
        }

        public string Scan()
        {
            return "ComboDevice Scan result";
        }
    }
}
