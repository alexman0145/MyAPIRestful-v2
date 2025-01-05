using Produit.Domain;

namespace Produit.BL
{
    public interface IService
    {
        public ProductLight GetProduct(int id);
    }
}