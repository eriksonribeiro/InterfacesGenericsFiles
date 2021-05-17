namespace RentalServiceWithoutInterface.Services
{
    class BrazilTaxService
    {
        public double Tax(double amount)
        {
            if (amount <= 200.00)
                return amount * 0.2;
            else
                return amount * 0.15;
        }
    }
}
