
using System;

namespace Store.Contracts
{
    public interface IProduct
    {
        string Name { get; }

        string Brand { get; }

        decimal Price { get; }

        decimal GetDiscount(DateTime purchasedOn);
    }
}
