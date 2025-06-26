using AulaInterface.Entities;
using System;

namespace AulaInterface.Services
{
    class RentalService
    {
        public double PricePerHour{ get; private set; }
        public double PricePerDay{ get; private set; }

        private ITaxService _taxService; //Inversao de controle por meio de injecao de dependencia
        // private BrazilTaxService _brazilTaxService = new BrazilTaxService(); // instancia dependencia, não é flexivel, jeito ruim de fazer

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double basicPayment = 0;
            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours); // Ceiling, arrendonda o teto
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }
            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
