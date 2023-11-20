using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopMethods
{
    internal static class PriceCalculator
    {
        /// <summary>
        /// Calculates the product price
        /// </summary>
        /// <param name="unitPrice"></param>
        /// <param name="quantity"></param>
        /// <param name="vatPercent"></param>
        /// <returns></returns>
        public static decimal CalculatePrice(decimal unitPrice, decimal quantity = 1M, decimal vatPercent = 19M)
        {
            return unitPrice * quantity * (1 + vatPercent / 100);
        }
    }
}
