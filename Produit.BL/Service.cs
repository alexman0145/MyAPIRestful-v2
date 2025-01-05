using Produit.Domain;
using Produit.Orm;

namespace Produit.BL
{
    public class Service : IService
    {
        private readonly IData _data;

        public Service(IData data)
        {
            _data = data;
        }
public ProductLight GetProduct(int id)
{
    return _data.GetProducts()
        .Where(p => p.Id == id)
        .Select(p => new ProductLight
        {
            Id = p.Id,
            Name = p.Name,
            LastOrderDate = p.Orders.Last().Date,
        })
        .First();
}


}

}
