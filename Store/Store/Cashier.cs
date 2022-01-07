using Store.ProductModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Cashier
    {
        public Cashier()
        {

        }

        public void PrintReceipt(Dictionary<Product, double> cart, DateTime purchasedOn)
        {
            StringBuilder receipt = new StringBuilder();
            receipt.AppendLine($"Date: {purchasedOn.ToString("yyyy-MM-dd HH:mm:ss")}");
            receipt.AppendLine("---Products---");

            decimal totalPriceBeforeDiscount = 0;
            decimal totalPriceAfterDiscount = 0;
            decimal totalDiscount = 0;
            foreach (var productQuantity in cart)
            {
                Product product = productQuantity.Key;
                double quantity = productQuantity.Value;
                receipt.AppendLine(product.ToString());

                decimal price = product.Price * (decimal)quantity;
                totalPriceBeforeDiscount += price;
                receipt.AppendLine($"{quantity} x ${product.Price:F2} = ${price:F2}");

                decimal discountPercent = product.GetDiscount(purchasedOn);

                if(discountPercent > 0)
                {
                    decimal discountAmount = price * discountPercent;
                    totalDiscount += discountAmount;
                    price = price - discountAmount;
                    receipt.AppendLine($"#discount {discountPercent * 100}%  -${discountAmount:F2}");
                }

                totalPriceAfterDiscount += price;
                receipt.AppendLine();
            }

            receipt.AppendLine("-----------------------------------------------------------------------------------");
            receipt.AppendLine();

            receipt.AppendLine($"SUBTOTAL: ${totalPriceBeforeDiscount:F2}");
            receipt.AppendLine($"DISCOUNT: -${totalDiscount:F2}");
            receipt.AppendLine();
            receipt.AppendLine($"TOTAL: ${totalPriceAfterDiscount:F2}");

            Console.WriteLine(receipt.ToString().TrimEnd());
        }
    }
}
