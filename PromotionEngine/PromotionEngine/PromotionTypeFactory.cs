using PromotionEngine.Helpers;
using PromotionEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class PromotionTypeFactory
    {
        public static IPromotionType GetPromotion(int promotionType)
        {
            IPromotionType objPromotionType;
            switch (promotionType)
            {
                case (int)PromotionTypes.NItemsSKU: objPromotionType = new NItemsSKU(); break;
                case (int)PromotionTypes.SKU1andSKU2: objPromotionType = new SKU1andSKU2(); break;
                default: objPromotionType = null; break;
            }
            return objPromotionType;
        }
    }
}
