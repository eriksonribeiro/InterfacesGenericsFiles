using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;

namespace ExerciseConjuntos.Entities
{
    static class TotalUser
    {
        public static void CountUser(string path)
        {
            HashSet<LogRecord> set = new HashSet<LogRecord>();

            //Console.Write("Enter file full path: ");
            //string path = Console.ReadLine();
            //string path = @"C:\GitHub\CSharp\WorkingWithGenerics\ExerciseConjuntos\Files\IN.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string []line = sr.ReadLine().Split(';');
                        string name = line[0];
                        DateTime instant = DateTime.ParseExact(line[1], "s", CultureInfo.InvariantCulture);
                        set.Add(new LogRecord(name, instant));
                    }

                    Console.WriteLine($"Total Users: {set.Count}");
                }

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
