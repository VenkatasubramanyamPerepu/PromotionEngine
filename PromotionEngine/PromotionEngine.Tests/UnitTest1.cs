using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine.Helpers;
using PromotionEngine.Interfaces;
using System.Collections.Generic;

namespace PromotionEngine.Tests
{
    [TestClass]
    public class PromotionEngineUnitTest
    {
        [TestMethod]
        public void TestScenarioA()
        {
            PromotionTypeFactory promotionTypeFactory = new PromotionTypeFactory();
            List<char> sampleCartItems = new List<char>();
            sampleCartItems.Add('A');
            sampleCartItems.Add('B');
            sampleCartItems.Add('C');
            IPromotionType promotion1 = PromotionTypeFactory.GetPromotion((int)PromotionTypes.NItemsSKU);
            IPromotionType promotion2 = PromotionTypeFactory.GetPromotion((int)PromotionTypes.SKU1andSKU2);
            decimal finalOrderValue = promotion1.CaliculatePromotionValue(sampleCartItems) + promotion2.CaliculatePromotionValue(sampleCartItems);
            Assert.AreEqual(finalOrderValue, 100);
        }
        [TestMethod]
        public void TestScenarioB()
        {
            PromotionTypeFactory promotionTypeFactory = new PromotionTypeFactory();
            List<char> sampleCartItems = new List<char>();
            for (int i = 0; i < 5; i++)
            {
                sampleCartItems.Add('A');
                sampleCartItems.Add('B');
            }
            sampleCartItems.Add('C');
            IPromotionType promotion1 = PromotionTypeFactory.GetPromotion((int)PromotionTypes.NItemsSKU);
            IPromotionType promotion2 = PromotionTypeFactory.GetPromotion((int)PromotionTypes.SKU1andSKU2);
            decimal finalOrderValue = promotion1.CaliculatePromotionValue(sampleCartItems) + promotion2.CaliculatePromotionValue(sampleCartItems);
            Assert.AreEqual(finalOrderValue, 370);
        }
        [TestMethod]
        public void TestScenarioC()
        {
            PromotionTypeFactory promotionTypeFactory = new PromotionTypeFactory();
            List<char> sampleCartItems = new List<char>();
            for (int i = 0; i < 3; i++)
            {
                sampleCartItems.Add('A');
            }
            for (int i = 0; i < 5; i++)
            {
                sampleCartItems.Add('B');
            }
            sampleCartItems.Add('C');
            sampleCartItems.Add('D');
            IPromotionType promotion1 = PromotionTypeFactory.GetPromotion((int)PromotionTypes.NItemsSKU);
            IPromotionType promotion2 = PromotionTypeFactory.GetPromotion((int)PromotionTypes.SKU1andSKU2);
            decimal finalOrderValue = promotion1.CaliculatePromotionValue(sampleCartItems) + promotion2.CaliculatePromotionValue(sampleCartItems);
            Assert.AreEqual(finalOrderValue, 280);
        }
    }
}
