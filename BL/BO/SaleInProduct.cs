

namespace BO;

public class SaleInProduct
{
    public int Id { get; set; }
    public int Amount { get; set; }
    public double Price { get; set; }
    public bool IsIntendedForAll { get; set; }
    public override string ToString() => this.ToStringProperty();
}
