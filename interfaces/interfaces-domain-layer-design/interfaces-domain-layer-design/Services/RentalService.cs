using interfaces_domain_layer_design.Entities;
using System;
using System.Text;

namespace interfaces_domain_layer_design.Services
{
    class RentalService
    {
        public double PricePerHour { get; set; }
        public double PricePerDay { get; set; }

        private BrasilTaxService _brazilTaxService = new BrasilTaxService();

        private ITaxService _taxService;


        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService) 
        {

            PricePerDay = pricePerDay;
            PricePerHour = pricePerHour;  
            _taxService = taxService;
            
        }
        public void ProcessInvoid(CarRental carRental) 
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;

            if (duration.TotalHours <= 12.0) 
            {
                
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            
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
