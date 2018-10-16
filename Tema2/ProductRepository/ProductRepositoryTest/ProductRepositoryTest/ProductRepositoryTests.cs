using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProductRepositoryTest
{
    [TestClass]
    public class ProductRepositoryTests
    {

        private ProductRepository product;

        [TestInitialize]
        public void TestInitialize()
        {
            product = new ProductRepository("stilou", "scrie frumos", DateTime.Now.AddDays(-3), DateTime.Now.AddDays(3), 109, 20, 5);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            product = null;
        }
        [TestMethod]
        public void When_GetProductByNameIsCalled_ThenShould_ReturnProduct()
        {
            var result = product.GetProductByName();

            result.Should().Be($"{product.Name} {product.Description}{product.StartDate}{product.EndDate}{product.id} {product.price} {product.VAT}");
        }
        [TestMethod]
        public void When_GetProductByPositionIsCalled_ThenShould_ReturnProduct()
        {
            var result = product.GetProductByPosition();

            result.Should().Be($"{product.Name} {product.Description}{product.StartDate}{product.EndDate}{product.id} {product.price} {product.VAT}");
        }
    }
}