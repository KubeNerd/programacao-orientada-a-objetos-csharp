using System;
using System.Globalization;
namespace desafio_proposto_heranca_polimorfismo.Entities
{
    class ImportedProduct: Product
    {
        public double CustomsFee { get; set; }


        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customsFree)
            : base(name, price)
        {

            CustomsFee = customsFree;

        }


        public double TotalPrice() 
        { 
            
            return Price + CustomsFee; 
        
        }


        public override string PriceTag()
        {
            return Name 
                + " R$ " 
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + " (Custom free): R$ "
                + CustomsFee.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }   


    }
}
