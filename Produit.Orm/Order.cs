namespace Produit.Orm
{
    public class Order
    {
        public int Id { get; set; }
        public DateOnly? Date { get; set; }
        public int ProduitId { get; set; }
    }
}