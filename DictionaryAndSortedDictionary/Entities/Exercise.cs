using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DictionaryAndSortedDictionary.Entities
{
    static class Exercise
    {
        public static void RunExercise(string path)
        {
            Dictionary<string, int> vote = new Dictionary<string, int>(); 
            //Console.Write("Enter file full path: ");
            //string path = Console.ReadLine();
            try
            {
                //string path = @"C:\GitHub\CSharp\WorkingWithGenerics\DictionaryAndSortedDictionary\Files\input.csv";

                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] file = sr.ReadLine().Split(';');

                        if (!vote.ContainsKey(file[0]))
                            vote[file[0]] = int.Parse(file[1]);
                        else
                            vote[file[0]] += int.Parse(file[1]);
                    }
                }

                foreach (var item in vote)
                    Console.WriteLine($"Candidate: {item.Key}  Votes: {item.Value}");

            }
            catch (IOException e )
            {
                Console.WriteLine(e.Message);
            }

        }

    }
}
