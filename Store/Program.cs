using Store.Enums;
using Store.ProductModels;
using System;
using System.Collections.Generic;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            Cashier cashier = new Cashier();

            cashier.PrintReceipt(FillCart(), new DateTime(2021, 6, 14, 12, 34, 56));
        }

        private static Dictionary<Product, double> FillCart()
        {
            Dictionary<Product, double> cart = new Dictionary<Product, double>();

            cart.Add(new Food("apples", "BrandA", 1.50M, new DateTime(2021, 6, 14)), 2.45);
            cart.Add(new Beverage("milk", "BrandM", 0.99M, new DateTime(2022, 2, 2)), 3);
            cart.Add(new Clothes("T-shirt", "BrandT", 15.99M, Size.M, "violet"), 2);
            cart.Add(new Appliance("laptop", "BrandL", 2345, "ModelL", new DateTime(2021, 03, 03), 1.125), 1);

            return cart;
        }

    }
}
