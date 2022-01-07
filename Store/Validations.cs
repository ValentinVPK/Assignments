using System;

namespace Store
{
    public static class Validations
    {
        public static void ThrowIfStringIsIncorrect(string name, string message)
        {
            if(String.IsNullOrEmpty(name) || String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException(message);
            }
        }

        public static void ThrowIfPriceIsNegativeOrZero(decimal price, string message)
        {
            if(price <= 0)
            {
                throw new ArgumentException(message);
            }
        }

        public static void ThrowIfWeightIsNegativeOrZero(double number, string message)
        {
            if(number <= 0)
            {
                throw new ArgumentException(message);
            }
        }
    }
}
