using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciseConjuntos.Entities;
namespace ExerciseConjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            TotalUser.CountUser(@"C:\GitHub\CSharp\WorkingWithGenerics\ExerciseConjuntos\Files\IN.txt");
            Console.ReadKey();
        }
    }
}
