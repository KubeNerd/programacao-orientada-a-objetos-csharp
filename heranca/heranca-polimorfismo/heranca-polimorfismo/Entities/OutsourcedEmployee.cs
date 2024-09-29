
namespace heranca_polimorfismo.Entities
{
    class OutsourcedEmployee : Employee
    {
     
        public double AdditionalCharge { get; set; }
        public OutsourcedEmployee()
        {
           
        }


        public OutsourcedEmployee(double additionalCharge, string name, int hours, double valuePerHour) 
            : base(name, hours, valuePerHour)
        { 
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;

        }


    }
}
