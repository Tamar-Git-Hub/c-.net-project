


namespace BO;

public class ProductInOrder
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int Amount { get; set; }
    public List<SaleInProduct> Sales { get; set; } = new List<SaleInProduct>();
    public double TotalPrice { get; set; }
    public string? Product { get; set; }

    public override string ToString() => this.ToStringProperty();
}
