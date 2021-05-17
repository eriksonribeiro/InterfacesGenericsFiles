using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingEqualAndGetHashCode.Entities
{
   static class Example
    {
        public static void EqualsExample()
        {
            string a = "Maria";
            string b = "Alex";
            string c = "Maria";


            Client d = new Client { Name = "Maria", Email = "maria@gmail.com" };
            Client e = new Client { Name = "Alex", Email = "alex@gmail.com" };
            Client f = new Client { Name = "Maria B", Email = "maria@gmail.com" };

            Console.WriteLine($"{a} is equal {b} = {a.Equals(b)}");
            Console.WriteLine($"{a} is equal {c} = {a.Equals(c)}");
            Console.WriteLine();
            Console.WriteLine($"{d.Name} is equal {e.Name} = {d.Equals(e)}");
            Console.WriteLine($"{d.Name} is equal {f.Name} = {d.Equals(f)}");
            Console.WriteLine();
        }

        public static void GetHashCodeExample()
        {
            string a = "Maria";
            string b = "Alex";
            string c = "Maria";

            Client d = new Client { Name = "Maria", Email = "maria@gmail.com" };
            Client e = new Client { Name = "Alex", Email = "alex@gmail.com" };
            Client f = new Client { Name = "Maria B", Email = "maria@gmail.com" };

            Console.WriteLine($"{a} HashCode = {a.GetHashCode()}");
            Console.WriteLine($"{c} HashCode = {c.GetHashCode()}");
            Console.WriteLine($"{b} HashCode = {b.GetHashCode()}");

            Console.WriteLine();
            Console.WriteLine($"{d.Name} HashCode = {d.GetHashCode()}");
            Console.WriteLine($"{f.Name} HashCode = {f.GetHashCode()}");
            Console.WriteLine($"{e.Name} HashCode = {e.GetHashCode()}");

            Console.WriteLine();
        }

    }
}
