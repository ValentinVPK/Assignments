using Store.Contracts;
using System;

namespace Store.ProductModels
{
    public class Beverage : Product, IPerishable
    {
        public Beverage(string name, string brand, decimal price, DateTime expirationDate) 
            : base(name, brand, price)
        {
            this.ExpirationDate = expirationDate;
        }

        public DateTime ExpirationDate { get; private set; }

        public override decimal GetDiscount(DateTime purchasedOn)
        {
            int dayDifference = (int)(ExpirationDate - purchasedOn).TotalDays;
            if (dayDifference == 0)
            {
                return 0.5M;
            }
            else if (dayDifference <= 5)
            {
                return 0.1M;
            }

            return 0;
        }
    }
}
