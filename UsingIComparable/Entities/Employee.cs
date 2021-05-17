using System;
using System.Globalization;

namespace UsingIComparable.Entities
{
    class Employee: IComparable
    {
        private string _name { get; set; }
        private double _salary { get; set; }

        public Employee(string csvEmployee)
        {
            string[] vect = csvEmployee.Split(';');
            this._name = vect[0];
            this._salary = double.Parse(vect[1],CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return $"Name: {_name}, Salary: R${_salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Employee))
                throw new ArgumentException ("Comparing error: argument is not an Employee");

            Employee other = obj as Employee;

            return _name.CompareTo(other._name);
        }
    }
}
