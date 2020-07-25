using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Interfaces
{
    public interface IPromotionType
    {
        decimal CaliculatePromotionValue(List<char> SKUs);
    }
}
