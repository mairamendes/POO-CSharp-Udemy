using System.Globalization;


namespace AulaInterface.Services
{
     class BrazilTaxService : ITaxService // Nesse caso é interface e não herança
    {
        public double Tax(double amount)
        {
            if (amount <= 100.0)
            {
                return amount * 0.2;
            }
            else
            { 
                return amount * 0.15;
            }
        }

    }
}
