using Produit.Orm;

namespace Produit.Test {

    [TestClass]
    public sealed class TestOrm {
        [TestMethod]

        public void TestMethod1()
        {
            Data data = new Data();
            var result = data.GetProduits();
            Assert.IsNotNull(result);
        }

    }
}