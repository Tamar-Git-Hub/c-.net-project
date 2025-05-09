namespace BO;
public class Sale
{
    public int codeIndex { get; init; }
    public int ProductId { get; set; }
    public int MinAmount { get; set; }
    public double Price { get; set; }
    public bool Club { get; set; }
    public DateTime StartSaleDate { get; set; }
    public DateTime EndSaleDate { get; set; }
    public override string ToString() => this.ToStringProperty();
    public Sale(int code, int id, int min, double price, bool club, DateTime start, DateTime end )
    {
        this.codeIndex = code;
        this.ProductId = id;
        this.MinAmount = min;
        this.Price = price;
        this.Club = club;
        this.StartSaleDate = start;
        this.EndSaleDate = end;
    }

}
