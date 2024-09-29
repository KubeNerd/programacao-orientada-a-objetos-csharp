using System;
using System.Collections.Generic;
using System.Globalization;


namespace desafio_proposto_heranca_polimorfismo.Entities
{
    class UsedProduct: Product
    {

        public DateTime ManufactureDate { get; set; }

   
        public UsedProduct() 
        {
        
        }


        public UsedProduct(string name, double price, DateTime manufactureDate)
        : base(name, price)
        
        {
            manufactureDate = manufactureDate;
        }
        public override string PriceTag()
        {
            return Name
                + " (used) $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufacture date: "
                + ManufactureDate.ToString("dd/MM/yyyy")
                + ")";
        }

    }
}
