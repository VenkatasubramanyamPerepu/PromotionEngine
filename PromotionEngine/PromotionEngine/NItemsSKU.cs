using PromotionEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class NItemsSKU : IPromotionType
    {
        public decimal CaliculatePromotionValue(List<char> SKUs)
        {
            int skuAquantity = SKUs.FindAll(x => x == 'A').Count();
            int skuBquantity = SKUs.FindAll(x => x == 'B').Count();

            decimal skuAValue = (skuAquantity / 3) * 130 + (skuAquantity % 3) * 50;
            decimal skuBValue = (skuBquantity / 2) * 45 + (skuAquantity % 2) * 30;

            return skuAValue + skuBValue;
        }
    }
}
