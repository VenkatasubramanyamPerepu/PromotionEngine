using PromotionEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class SKU1andSKU2 : IPromotionType
    {
        public decimal CaliculatePromotionValue(List<char> SKUs)
        {
            int skuCquantity = SKUs.FindAll(x => x == 'C').Count();
            int skuDquantity = SKUs.FindAll(x => x == 'D').Count();
            if (skuCquantity == 0)
            {
                return skuDquantity * 15;
            }
            else if (skuDquantity == 0)
            {
                return skuCquantity * 20;
            }
            else
            {
                if (skuCquantity > skuDquantity)
                {
                    return skuDquantity * 30 + (skuCquantity - skuDquantity) * 20;
                }
                if (skuCquantity < skuDquantity)
                {
                    return skuCquantity * 30 + (skuDquantity - skuCquantity) * 15;
                }
                else
                {
                    return skuCquantity * 30;
                }
            }
        }
    }
}
