using System;
using System.Collections.Generic;
using System.IO;

namespace UsingIComparable.Entities
{
    class TreatFile
    {
        private string _path { get; set; }
        private List<Employee> _list = new List<Employee>();
        public TreatFile(string path)
        {
            this._path = path;
        }

        public void ReadFile()
        {
            try
            {
                using (StreamReader sr = File.OpenText(_path))
                {
                    while (!sr.EndOfStream)
                        _list.Add(new Employee(sr.ReadLine()));
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
        }

        public void SortData()
        {
            _list.Sort();
            foreach (Employee employee in _list)
                Console.WriteLine(employee);
        }
    }
}
