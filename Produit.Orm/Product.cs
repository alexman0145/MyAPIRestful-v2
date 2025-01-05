namespace Produit.Orm
{
    public class Product
    {
    public int Id { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}


