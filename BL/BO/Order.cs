namespace BO;

public class Order
{
    public bool IsFavorite { get; set; }
    public List<ProductInOrder> ProductsInOrder { get; set; } = new List<ProductInOrder>();
    public double TotalPrice { get; set; }
    public override string ToString() => this.ToStringProperty();
}
