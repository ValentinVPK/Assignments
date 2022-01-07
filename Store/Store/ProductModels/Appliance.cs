using Store.Contracts;
using System;


namespace Store.ProductModels
{
    public class Appliance : Product, IAppliance
    {
        private string model;
        private double weight;
        public Appliance(string name, string brand, decimal price, 
            string model, DateTime productionDate, double weight) 
            : base(name, brand, price)
        {
            this.Model = model;
            this.ProductionDate = productionDate;
            this.Weight = weight;
        }

        public string Model
        {
            get => this.model;
            private set
            {
                Validations.ThrowIfStringIsIncorrect(value, "Model should not be an empty string!");

                this.model = value;
            }
        }

        public DateTime ProductionDate { get; private set; }

        public double Weight
        {
            get => this.weight;
            private set
            {
                Validations.ThrowIfWeightIsNegativeOrZero(value, "Weight should not be less than or equal to zero!");

                this.weight = value;
            }
        }

        public override decimal GetDiscount(DateTime purchasedOn)
        {
            if(((int)purchasedOn.DayOfWeek == 6 || (int)purchasedOn.DayOfWeek == 7) && this.Price > 999)
            {
                return 0.05M;
            }

            return 0;
        }

        public override string ToString()
        {
            return base.ToString() + $" {this.Model}";
        }
    }
}
