using System;
using RentalServiceWithoutInterface.Entities;

namespace RentalServiceWithoutInterface.Services
{
    class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private BrazilTaxService _brazilTaxService = new BrazilTaxService();
        public RentalService(double pricePerHour, double pricePerDay)
        {
            this.PricePerHour = pricePerHour;
            this.PricePerDay = pricePerDay;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;

            if (duration.TotalHours <= 12.0)
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            else
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);

            double tax = _brazilTaxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }

    }
}
