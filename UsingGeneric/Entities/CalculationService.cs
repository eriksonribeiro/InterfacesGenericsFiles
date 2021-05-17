using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingGeneric.Entities
{
    class CalculationService
    {
        public int Max(List<int> list)
        { 
           if (list.Count == 0)
             throw new InvalidOperationException("List is Empty!");

            int max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] > max)
                    max = list[i];
            }

            return max;
        }

        public T MaxGeneric<T>(List<T> list) where T :IComparable
        {
            if (list.Count == 0)
                throw new InvalidOperationException("List is empty!");

            T max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(max) > 0)
                    max = list[i];
            }

            return max;
        }
    }
}
