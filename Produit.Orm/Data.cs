using Microsoft.EntityFrameworkCore;

namespace Produit.Orm
{
    public class Data : IData
    {
        private readonly ProduitOrmContext _dbcontext;
        public Data()
        {
            _dbcontext = new ProduitOrmContext();
        }

        public List<Product> GetProducts()
        {
            return _dbcontext.Produits.ToList();
        }

        public List<Product>GetCustomersOrder()
        {
            return _dbcontext.Produits.Include(p => p.Orders).ToList();
        }
    }
}