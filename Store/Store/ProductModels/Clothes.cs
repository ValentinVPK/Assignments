using Store.Contracts;
using Store.Enums;
using System;

namespace Store.ProductModels
{
    public class Clothes : Product, IClothes
    {
        private string color;
        public Clothes(string name, string brand, decimal price, Size size, string color) 
            : base(name, brand, price)
        {
            this.Size = size;
            this.Color = color;
        }

        public Size Size { get; private set; }

        public string Color
        {
            get => this.color;
            private set
            {
                Validations.ThrowIfStringIsIncorrect(value, "Color should not be an empty string!");

                this.color = value;
            }
        }

        public override decimal GetDiscount(DateTime purchasedOn)
        {
            if((int)purchasedOn.DayOfWeek >= 1 && (int)purchasedOn.DayOfWeek <= 5)
            {
                return 0.1M;
            }

            return 0;
        }

        public override string ToString()
        {
            return base.ToString() + $" {this.Size.ToString()} {this.Color}";
        }
    }
}
