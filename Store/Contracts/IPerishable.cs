using System;

namespace Store.Contracts
{
    public interface IPerishable
    {
        DateTime ExpirationDate { get; }
    }
}
