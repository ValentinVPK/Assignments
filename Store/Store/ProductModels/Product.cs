using Store.Contracts;
using System;

namespace Store.ProductModels
{
    public abstract class Product : IProduct
    {
        private string name;
        private string brand;
        private decimal price;

        protected Product(string name, string brand, decimal price)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                Validations.ThrowIfStringIsIncorrect(value, "Name should not be an empty string!");

                this.name = value;
            }
        }

        public string Brand
        {
            get => this.brand;
            private set
            {
                Validations.ThrowIfStringIsIncorrect(value, "Brand should not be an empty string!");

                this.brand = value;
            }
        }

        public decimal Price
        {
            get => this.price;
            private set
            {
                Validations.ThrowIfPriceIsNegativeOrZero(value, "Price should not be less than or equal to zero!");

                this.price = value;
            }
        }

        public abstract decimal GetDiscount(DateTime purchasedOn);

        public override string ToString()
        {
            return $"{this.Name} {this.Brand}";
        }
    }
}
