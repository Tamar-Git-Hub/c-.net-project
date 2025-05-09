namespace BO;
public class Product
{
    public List<SaleInProduct> SaleInProduct=new List<SaleInProduct>();
    public int Id { get; init; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int AmountInStock { get; set; }
    public Categories category { get; set; }
    public override string ToString() => this.ToStringProperty();
    public Product(int id, string name, double price, int amount, Categories cat)
    {
        this.Id = id;
        this.Name = name;
        this.Price = price;
        this.AmountInStock = amount;
        this.category = cat;
    }

}
