using System;
using UsingIComparable.Entities;

namespace UsingIComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            TreatFile tf = new TreatFile(@"C:\Git\WorkingWithInterfaces\UsingIComparable\File\in.csv");
            tf.ReadFile();
            tf.SortData();
            Console.ReadKey();
        }
    }
}
