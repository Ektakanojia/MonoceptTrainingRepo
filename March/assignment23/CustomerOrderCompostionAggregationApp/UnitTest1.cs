using CustomerOrderCompostionAggregationApp.Model;

namespace CustomerOrderCompostionAggregationApp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ItShouldValidateCustomer()
        {
            string exceptedId = "01";
            string exceptedName = "Ekta";
            Customer customer = new Customer("Ekta", "01");
            string actualId = customer.Id;
            string actualName = customer.Name;
            Assert.AreEqual(exceptedId, actualId);
            Assert.AreEqual(exceptedName, actualName);

        }
        [TestMethod]
        public void ItShouldCalculateTheProductPriceAfterDiscount() 
        {
            string exceptedId = "01";
            string exceptedName = "Lenovo";
            double exceptedPrice = 4000;
            double exceptedDiscountPercent = .05;
            double exceptedPriceAfterDiscounnt = 200;
            Product product = new Product("01", "Lenovo", 4000, .05);
            string actualId = product.Id;
            string actualName = product.Name;
            double actualPrice = product.Price;
            double actualDiscountPercent = product.DiscountPercentage;
            double actualPriceAfterDiscount = product.CalculatePriceAfterDiscount(4000, .05);
            Assert.AreEqual(exceptedId, actualId);
            Assert.AreEqual(exceptedName, actualName);
            Assert.AreEqual(exceptedPrice, actualPrice);
            Assert.AreEqual(exceptedDiscountPercent, actualDiscountPercent);
            Assert.AreEqual(exceptedPriceAfterDiscounnt, actualPriceAfterDiscount);

        
        }
        [TestMethod]
        public void ItShouldCalculateTheItemCost()
        {
            string exceptedId = "01";
            string exceptedProductName = "Lenovo";
            int exceptedQuantatiy = 2;
            double exceptedPrice = 50000;
            double exceptedDiscountPercent = .05;
            double exceptedCostItem = 5000;
        }

    }
}