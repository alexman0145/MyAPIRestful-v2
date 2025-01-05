using Produit.BL;
using Produit.Orm;
using Produit.Domain;
using Moq;

namespace Produit.Test
{
    [TestClass]
    public sealed class TestBL
    {
        [TestMethod]
        public void TestMethod1()
        {
            var dataMock = new Mock<IData>();

            dataMock.Setup(x => x.GetProducts()).Returns(new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Produit 1",
                    Orders = new List<Order>
                    {
                        new Order
                        {
                            Id = 1,
                            Date = DateOnly.FromDateTime(DateTime.Now),
                            ProduitId = 1
                        }
                    }
                }
            });

            IService service = new Service(dataMock.Object);

            var result = service.GetProduct(1);

            Assert.IsNotNull(result);

        }
    }
}

