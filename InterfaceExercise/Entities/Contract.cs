using System;
using System.Collections.Generic;

namespace InterfaceExercise.Entities
{
     class Contract
    {
        public int Number { get; private set; }
        public DateTime Date { get; private set; }
        public double TotalValue { get; set; }

        public List<Installment> Installments { get; set; }

        public Contract(int number, DateTime date,double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installments = new List<Installment>();
        }

        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }

    }
}
